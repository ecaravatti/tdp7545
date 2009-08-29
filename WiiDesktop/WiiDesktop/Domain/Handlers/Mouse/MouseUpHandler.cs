using System;
using System.Collections.Generic;
using System.Text;
using WiimoteLib;
using System.Runtime.InteropServices;
using System.Drawing;
using WiiDesktop.Domain.Cursor;

namespace WiiDesktop.Domain.Handlers.Mouse
{
    class MouseUpHandler : MouseHandler
    {
        public MouseUpHandler(EventHandler nextHandler, int screenWidth, int screenHeight)
               : base(nextHandler, screenWidth, screenHeight)
        {
        }

        override protected bool InnerHandle(WiimoteState currentState, WiimoteState lastState)
        {
            if (!currentState.IRState.Found1 && lastState.IRState.Found1)
            {
                TimeSpan elapsedSpan = new TimeSpan(DateTime.Now.Ticks - mouseDownStartTime);
                
                if ((elapsedSpan.TotalSeconds >= MouseHandler.MOUSE_DOWN_DELAY) && CheckProximity()) // Right click
                {
                    INPUT[] buffer = CreateMouseRightClickInput();
                    SendInput(4, buffer, Marshal.SizeOf(buffer[0]));
                }
                else
                {
                    INPUT[] buffer = CreateMouseInput();
                    SendInput(1, buffer, Marshal.SizeOf(buffer[0]));
                }

                return true;
            }

            return false;
        }

        private bool CheckProximity()
        {
            return (Math.Abs(mouseDownStartPoint.X - mouseDownEndPoint.X) <= MouseHandler.MOUSE_DOWN_POINT_MARGIN) &&
                   (Math.Abs(mouseDownStartPoint.Y - mouseDownEndPoint.Y) <= MouseHandler.MOUSE_DOWN_POINT_MARGIN);
        }

        private INPUT[] CreateMouseInput()
        {
            INPUT[] buffer = new INPUT[1];
            buffer[0].type = INPUT_MOUSE;
            buffer[0].mi.dx = 0;
            buffer[0].mi.dy = 0;
            buffer[0].mi.mouseData = 0;
            buffer[0].mi.dwFlags = MOUSEEVENTF_LEFTUP;
            buffer[0].mi.time = 0;
            buffer[0].mi.dwExtraInfo = (IntPtr)0;

            return buffer;
        }

        private INPUT[] CreateMouseRightClickInput()
        {
            INPUT[] buffer = new INPUT[4];
            buffer[0].type = INPUT_MOUSE;
            buffer[0].mi.dx = 0;
            buffer[0].mi.dy = 0;
            buffer[0].mi.mouseData = 0;
            buffer[0].mi.dwFlags = MOUSEEVENTF_LEFTUP;
            buffer[0].mi.time = 0;
            buffer[0].mi.dwExtraInfo = (IntPtr)0;

            buffer[1].type = INPUT_MOUSE;
            buffer[1].mi.dx = (int)(mouseDownStartPoint.X * 65535.0f / screenWidth);
            buffer[1].mi.dy = (int)(mouseDownStartPoint.Y * 65535.0f / screenHeight);
            buffer[1].mi.mouseData = 0;
            buffer[1].mi.dwFlags = MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE;
            buffer[1].mi.time = 0;
            buffer[1].mi.dwExtraInfo = (IntPtr)0;

            buffer[2].type = INPUT_MOUSE;
            buffer[2].mi.dx = 0;
            buffer[2].mi.dy = 0;
            buffer[2].mi.mouseData = 0;
            buffer[2].mi.dwFlags = MOUSEEVENTF_RIGHTDOWN;
            buffer[2].mi.time = 0;
            buffer[2].mi.dwExtraInfo = (IntPtr)0;

            buffer[3].type = INPUT_MOUSE;
            buffer[3].mi.dx = 0;
            buffer[3].mi.dy = 0;
            buffer[3].mi.mouseData = 0;
            buffer[3].mi.dwFlags = MOUSEEVENTF_RIGHTUP;
            buffer[3].mi.time = 0;
            buffer[3].mi.dwExtraInfo = (IntPtr)0;

            return buffer;
        }
    }
}