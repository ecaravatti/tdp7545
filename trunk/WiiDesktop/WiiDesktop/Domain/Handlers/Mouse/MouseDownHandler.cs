using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using WiimoteLib;
using WiiDesktop.Domain.Cursor;
using System.Runtime.InteropServices;

namespace WiiDesktop.Domain.Handlers.Mouse
{
    class MouseDownHandler : MouseHandler
    {
        private int screenWidth;
        private int screenHeight;

        public MouseDownHandler(EventHandler nextHandler, int screenWidth, int screenHeight)
        {
            this.nextHandler = nextHandler;
            this.screenWidth = screenWidth;
            this.screenHeight = screenHeight;
        }

        override protected bool InnerHandle(WiimoteState currentState, WiimoteState lastState)
        {
            if (currentState.IRState.Found1 && !lastState.IRState.Found1)
            {
                PointF warpedCoordinates = CursorWarper.warp(new PointF(currentState.IRState.RawX1, currentState.IRState.RawY1));
                CursorSmoother.smoothCursor(warpedCoordinates);
                CursorSmoother.SmoothingBufferIndex = 0;

                INPUT[] buffer = CreateMouseInput(ref warpedCoordinates);

                SendInput(2, buffer, Marshal.SizeOf(buffer[0]));

                return true;
            }

            return false;
        }

        private INPUT[] CreateMouseInput(ref PointF warpedCoordinates)
        {
            INPUT[] buffer = new INPUT[2];
            buffer[0].type = INPUT_MOUSE;
            buffer[0].mi.dx = (int)(warpedCoordinates.X * 65535.0f / screenWidth);
            buffer[0].mi.dy = (int)(warpedCoordinates.Y * 65535.0f / screenHeight);
            buffer[0].mi.mouseData = 0;
            buffer[0].mi.dwFlags = MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE;
            buffer[0].mi.time = 0;
            buffer[0].mi.dwExtraInfo = (IntPtr)0;

            buffer[1].type = INPUT_MOUSE;
            buffer[1].mi.dx = 0;
            buffer[1].mi.dy = 0;
            buffer[1].mi.mouseData = 0;
            buffer[1].mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            buffer[1].mi.time = 1;
            buffer[1].mi.dwExtraInfo = (IntPtr)0;
            return buffer;
        }

    }
}
