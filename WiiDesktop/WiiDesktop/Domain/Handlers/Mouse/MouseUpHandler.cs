using System;
using System.Collections.Generic;
using System.Text;
using WiimoteLib;
using System.Runtime.InteropServices;

namespace WiiDesktop.Domain.Handlers.Mouse
{
    class MouseUpHandler : MouseHandler
    {
        public MouseUpHandler(EventHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        override protected bool InnerHandle(WiimoteState currentState, WiimoteState lastState)
        {
            if (!currentState.IRState.Found1 && lastState.IRState.Found1)
            {
                INPUT[] buffer = CreateMouseInput();

                SendInput(2, buffer, Marshal.SizeOf(buffer[0]));

                return true;
            }

            return false;
        }

        private static INPUT[] CreateMouseInput()
        {
            INPUT[] buffer = new INPUT[2];
            buffer[0].type = INPUT_MOUSE;
            buffer[0].mi.dx = 0;
            buffer[0].mi.dy = 0;
            buffer[0].mi.mouseData = 0;
            buffer[0].mi.dwFlags = MOUSEEVENTF_LEFTUP;
            buffer[0].mi.time = 0;
            buffer[0].mi.dwExtraInfo = (IntPtr)0;

            buffer[1].type = INPUT_MOUSE;
            buffer[1].mi.dx = 0;
            buffer[1].mi.dy = 0;
            buffer[1].mi.mouseData = 0;
            buffer[1].mi.dwFlags = MOUSEEVENTF_MOVE;
            buffer[1].mi.time = 0;
            buffer[1].mi.dwExtraInfo = (IntPtr)0;
            return buffer;
        }
    }
}