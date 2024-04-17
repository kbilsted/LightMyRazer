using Colore;
using Colore.Effects.Keyboard;
using Colore.Data;
using SharpHook;
using System.Collections.Concurrent;

namespace Kbg.LightMyRazer;

internal class Program
{
    static ConcurrentQueue<ushort> KeyQueue = new ConcurrentQueue<ushort>();
    static CancellationTokenSource cts = new CancellationTokenSource();
    static CustomKeyboardEffect effect = new CustomKeyboardEffect(Color.Black);

    static async Task Main(string[] args)
    {
        var appInfo = new AppInfo("Light my Razer",
            "Light chroma when using other keyboards",
            "Kasper B. Graversen",
            "bolig48@gmail.com",
            Category.Application);
        using IChroma chroma = await ColoreProvider.CreateRestAsync(appInfo);
        Thread.Sleep(150);


        using var hook = new TaskPoolGlobalHook();
        hook.KeyPressed += OnKeyPressed;
        hook.RunAsync();

        var kl = new KeyListen(KeyQueue, effect);
        Task.Run(() => kl.KeyListener(cts.Token), cts.Token);

        int decay = 2;
        var fader = new RazerFadeEffect(effect, decay);

        while (true)
        {
            bool changed = fader.FadeAllKeys();

            if (changed)
            {
                await chroma.Keyboard.SetCustomAsync(effect);
            }

            Thread.Sleep(100);
        }

        cts.Cancel();

    }

    /// <summary>
    /// just enqueue presses so the keyhandler is never a bottleneck to the OS which may slay our process if we become slow
    /// </summary>
    private static void OnKeyPressed(object? sender, KeyboardHookEventArgs e) => KeyQueue.Enqueue(e.Data.RawCode);

}
