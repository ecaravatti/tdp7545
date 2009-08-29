using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using WiiDesktop.Domain.Cursor;
using System.Runtime.InteropServices;

namespace WiiDesktop.Domain.Handlers
{
    abstract class MouseHandler : EventHandler
    {
        public const int INPUT_MOUSE = 0;

        public const int MOUSEEVENTF_MOVE = 0x01;
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        public const int MOUSEEVENTF_MIDDLEUP = 0x40;
        public const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        
        // Tiempo mínimo (en segundos) que hay que mantener apretado
        // el puntero para interpretar el evento como un click derecho.
        public const int MOUSE_DOWN_DELAY = 1;

        // Distancia (en pixeles) que puede variar la posición del puntero
        // cuando se desea realiar un click derecho.
        public const int MOUSE_DOWN_POINT_MARGIN = 100;

        protected int screenWidth;
        protected int screenHeight;
        protected static long mouseDownStartTime = 0;
        protected static PointF mouseDownStartPoint = new PointF(0, 0);
        protected static PointF mouseDownEndPoint = new PointF(0, 0);

        [DllImport("user32.dll", SetLastError = true)]
        protected static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        [StructLayout(LayoutKind.Explicit, Size = 28)]
        public struct INPUT
        {
            [FieldOffset(0)]
            public int type;
            [FieldOffset(4)]
            public MOUSEINPUT mi;
            [FieldOffset(4)]
            public KEYBDINPUT ki;
            [FieldOffset(4)]
            public HARDWAREINPUT hi;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSEINPUT
        {
            public int dx;//4
            public int dy;//4
            public uint mouseData;//4
            public uint dwFlags;//4
            public uint time;//4
            public IntPtr dwExtraInfo;//4
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct KEYBDINPUT
        {
            public ushort wVk;//2
            public ushort wScan;//2
            public uint dwFlags;//4
            public uint time;//4
            public IntPtr dwExtraInfo;//4
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HARDWAREINPUT
        {
            public uint uMsg;
            public ushort wParamL;
            public ushort wParamH;
        }

        public MouseHandler(EventHandler nextHandler, int screenWidth, int screenHeight)
        {
            this.nextHandler = nextHandler;
            this.screenWidth = screenWidth;
            this.screenHeight = screenHeight;
        }

    }
}
