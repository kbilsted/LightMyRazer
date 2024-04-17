using Colore.Effects.Keyboard;
using Colore.Data;

namespace Kbg.LightMyRazer;

class RazerFadeEffect(CustomKeyboardEffect effect, int decay)
{
    static Color[] Colors =
   {
        Color.Blue,
        Color.Green,
        Color.HotPink,
        Color.Orange,
        Color.Pink,
        Color.Purple,
        Color.Red,
        Color.Yellow,
    };

    bool fader(Key k)
    {
        Color color1 = effect[k];

        if (color1 == Color.White)
        {
            effect[k] = new Color(104, 255, 100);
            //effect[k] = Colors[Random.Shared.Next(Colors.Length)];
            return true;
        }

        if (color1 != Color.Black)
        {
            Color ndarker = new Color(
                             (byte)Math.Max(0, color1.R - decay),
                             (byte)Math.Max(0, color1.G - decay),
                             (byte)Math.Max(0, color1.B - decay));
            effect[k] = ndarker;
            return true;
        }

        return false;
    }


    public bool FadeAllKeys()
    {
        bool change = false;
        change |= fader(Key.Logo);
        change |= fader(Key.Escape);
        change |= fader(Key.F1);
        change |= fader(Key.F2);
        change |= fader(Key.F3);
        change |= fader(Key.F4);
        change |= fader(Key.F5);
        change |= fader(Key.F6);
        change |= fader(Key.F7);
        change |= fader(Key.F8);
        change |= fader(Key.F9);
        change |= fader(Key.F10);
        change |= fader(Key.F11);
        change |= fader(Key.F12);
        change |= fader(Key.D1);
        change |= fader(Key.D2);
        change |= fader(Key.D3);
        change |= fader(Key.D4);
        change |= fader(Key.D5);
        change |= fader(Key.D6);
        change |= fader(Key.D7);
        change |= fader(Key.D8);
        change |= fader(Key.D9);
        change |= fader(Key.D0);
        change |= fader(Key.A);
        change |= fader(Key.B);
        change |= fader(Key.C);
        change |= fader(Key.D);
        change |= fader(Key.E);
        change |= fader(Key.F);
        change |= fader(Key.G);
        change |= fader(Key.H);
        change |= fader(Key.I);
        change |= fader(Key.J);
        change |= fader(Key.K);
        change |= fader(Key.L);
        change |= fader(Key.M);
        change |= fader(Key.N);
        change |= fader(Key.O);
        change |= fader(Key.P);
        change |= fader(Key.Q);
        change |= fader(Key.R);
        change |= fader(Key.S);
        change |= fader(Key.T);
        change |= fader(Key.U);
        change |= fader(Key.V);
        change |= fader(Key.W);
        change |= fader(Key.X);
        change |= fader(Key.Y);
        change |= fader(Key.Z);
        change |= fader(Key.NumLock);
        change |= fader(Key.Num0);
        change |= fader(Key.Num1);
        change |= fader(Key.Num2);
        change |= fader(Key.Num3);
        change |= fader(Key.Num4);
        change |= fader(Key.Num5);
        change |= fader(Key.Num6);
        change |= fader(Key.Num7);
        change |= fader(Key.Num8);
        change |= fader(Key.Num9);
        change |= fader(Key.NumDivide);
        change |= fader(Key.NumMultiply);
        change |= fader(Key.NumSubtract);
        change |= fader(Key.NumAdd);
        change |= fader(Key.NumEnter);
        change |= fader(Key.NumDecimal);
        change |= fader(Key.PrintScreen);
        change |= fader(Key.Scroll);
        change |= fader(Key.Pause);
        change |= fader(Key.Insert);
        change |= fader(Key.Home);
        change |= fader(Key.PageUp);
        change |= fader(Key.Delete);
        change |= fader(Key.End);
        change |= fader(Key.PageDown);
        change |= fader(Key.Up);
        change |= fader(Key.Left);
        change |= fader(Key.Down);
        change |= fader(Key.Right);
        change |= fader(Key.Tab);
        change |= fader(Key.CapsLock);
        change |= fader(Key.Backspace);
        change |= fader(Key.Enter);
        change |= fader(Key.LeftControl);
        change |= fader(Key.LeftWindows);
        change |= fader(Key.LeftAlt);
        change |= fader(Key.Space);
        change |= fader(Key.RightAlt);
        change |= fader(Key.Function);
        change |= fader(Key.RightMenu);
        change |= fader(Key.RightControl);
        change |= fader(Key.LeftShift);
        change |= fader(Key.RightShift);
        //change |= fader(Key.Macro1);
        //change |= fader(Key.Macro2);
        //change |= fader(Key.Macro3);
        //change |= fader(Key.Macro4);
        //change |= fader(Key.Macro5);
        change |= fader(Key.OemTilde);
        change |= fader(Key.OemMinus);
        change |= fader(Key.OemEquals);
        change |= fader(Key.OemLeftBracket);
        change |= fader(Key.OemRightBracket);
        change |= fader(Key.OemBackslash);
        change |= fader(Key.OemSemicolon);
        change |= fader(Key.OemApostrophe);
        change |= fader(Key.OemComma);
        change |= fader(Key.OemPeriod);
        change |= fader(Key.OemSlash);
        change |= fader(Key.EurPound);
        change |= fader(Key.EurBackslash);
        //change |= fader(Key.JpnYen);
        //change |= fader(Key.JpnSlash);
        //change |= fader(Key.Jpn3);
        //change |= fader(Key.Jpn4);
        //change |= fader(Key.Jpn5);
        //change |= fader(Key.KorPipe);
        //change |= fader(Key.Kor2);
        //change |= fader(Key.Kor3);
        //change |= fader(Key.Kor4);
        //change |= fader(Key.Kor5);
        //change |= fader(Key.Kor6);
        //change |= fader(Key.Kor7);
        return change;
    }
}
