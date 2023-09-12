using SFML.Window;
using SFML.System;
using SFML.Graphics;

namespace VoilaEngine{
    public enum Axis{
        Horizontal,
        Vertical
    }
    public class Input{
        public static Keyboard.Key K_A = Keyboard.Key.A;
        public static Keyboard.Key K_B = Keyboard.Key.B;
        public static Keyboard.Key K_C = Keyboard.Key.C;
        public static Keyboard.Key K_D = Keyboard.Key.D;
        public static Keyboard.Key K_E = Keyboard.Key.E;
        public static Keyboard.Key K_F = Keyboard.Key.F;
        public static Keyboard.Key K_G = Keyboard.Key.G;
        public static Keyboard.Key K_H = Keyboard.Key.H;
        public static Keyboard.Key K_I = Keyboard.Key.I;
        public static Keyboard.Key K_J = Keyboard.Key.J;
        public static Keyboard.Key K_K = Keyboard.Key.K;
        public static Keyboard.Key K_L = Keyboard.Key.L;
        public static Keyboard.Key K_M = Keyboard.Key.M;
        public static Keyboard.Key K_N = Keyboard.Key.N;
        public static Keyboard.Key K_O = Keyboard.Key.O;
        public static Keyboard.Key K_P = Keyboard.Key.P;
        public static Keyboard.Key K_Q = Keyboard.Key.Q;
        public static Keyboard.Key K_R = Keyboard.Key.R;
        public static Keyboard.Key K_S = Keyboard.Key.S;
        public static Keyboard.Key K_T = Keyboard.Key.T;
        public static Keyboard.Key K_U = Keyboard.Key.U;
        public static Keyboard.Key K_V = Keyboard.Key.V;
        public static Keyboard.Key K_W = Keyboard.Key.W;
        public static Keyboard.Key K_X = Keyboard.Key.X;
        public static Keyboard.Key K_Y = Keyboard.Key.Y;
        public static Keyboard.Key K_Z = Keyboard.Key.Z;
        public static Keyboard.Key K_SPACE = Keyboard.Key.Space;
        public static Keyboard.Key K_ESCAPE = Keyboard.Key.Escape;
        public static Keyboard.Key K_ENTER = Keyboard.Key.Enter;
        public static Keyboard.Key K_BACKSPACE = Keyboard.Key.Backspace;
        public static Keyboard.Key K_TAB = Keyboard.Key.Tab;
        public static Keyboard.Key K_LSHIFT = Keyboard.Key.LShift;
        public static Keyboard.Key K_RSHIFT = Keyboard.Key.RShift;
        public static Keyboard.Key K_LCTRL = Keyboard.Key.LControl;
        public static Keyboard.Key K_RCTRL = Keyboard.Key.RControl;
        public static Keyboard.Key K_LALT = Keyboard.Key.LAlt;
        public static Keyboard.Key K_RALT = Keyboard.Key.RAlt;
        public static Keyboard.Key K_UP = Keyboard.Key.Up;
        public static Keyboard.Key K_DOWN = Keyboard.Key.Down;
        public static Keyboard.Key K_LEFT = Keyboard.Key.Left;
        public static Keyboard.Key K_RIGHT = Keyboard.Key.Right;
        public static Keyboard.Key K_F1 = Keyboard.Key.F1;
        public static Keyboard.Key K_F2 = Keyboard.Key.F2;
        public static Keyboard.Key K_F3 = Keyboard.Key.F3;
        public static Keyboard.Key K_F4 = Keyboard.Key.F4;
        public static Keyboard.Key K_F5 = Keyboard.Key.F5;
        public static Keyboard.Key K_F6 = Keyboard.Key.F6;
        public static Keyboard.Key K_F7 = Keyboard.Key.F7;
        public static Keyboard.Key K_F8 = Keyboard.Key.F8;
        public static Keyboard.Key K_F9 = Keyboard.Key.F9;
        public static Keyboard.Key K_F10 = Keyboard.Key.F10;
        public static Keyboard.Key K_F11 = Keyboard.Key.F11;
        public static Keyboard.Key K_F12 = Keyboard.Key.F12;
        public static Keyboard.Key K_0 = Keyboard.Key.Num0;
        public static Keyboard.Key K_1 = Keyboard.Key.Num1;
        public static Keyboard.Key K_2 = Keyboard.Key.Num2;
        public static Keyboard.Key K_3 = Keyboard.Key.Num3;
        public static Keyboard.Key K_4 = Keyboard.Key.Num4;
        public static Keyboard.Key K_5 = Keyboard.Key.Num5;
        public static Keyboard.Key K_6 = Keyboard.Key.Num6;
        public static Keyboard.Key K_7 = Keyboard.Key.Num7;
        public static Keyboard.Key K_8 = Keyboard.Key.Num8;
        public static Keyboard.Key K_9 = Keyboard.Key.Num9;


        public static bool GetKey(Keyboard.Key key){
            return Keyboard.IsKeyPressed(key);
        }
        public static int GetAxisRaw(Axis axis){
            if(axis == Axis.Horizontal){
                return GetKey(K_D) ? 1 : GetKey(K_A) ? -1 : 0;
            }
            else if(axis == Axis.Vertical){
                return GetKey(K_W) ? -1 : GetKey(K_S) ? 1 : 0;
            }
            return 0;
        }
        
    }
}