using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using WiiDesktop.Domain.Cursor;
using WiimoteLib;
using System.Runtime.InteropServices;

namespace WiiDesktop.Domain.Handlers.Mouse
{
    class MouseDragHandler : MouseHandler
    {
        public MouseDragHandler(EventHandler nextHandler, int screenWidth, int screenHeight)
               : base(nextHandler, screenWidth, screenHeight)
        {
        }

        override protected bool InnerHandle(WiimoteState currentState, WiimoteState lastState)
        {
            if (currentState.IRState.Found1 && lastState.IRState.Found1)
            {
                PointF warpedCoordinates = CursorWarper.warp(new PointF(currentState.IRState.RawX1, currentState.IRState.RawY1));

                mouseDownEndPoint.X = warpedCoordinates.X;
                mouseDownEndPoint.Y = warpedCoordinates.Y;
                
                CursorSmoother.smoothCursor(warpedCoordinates);

                INPUT[] buffer = CreateMouseInput();

                SendInput(1, buffer, Marshal.SizeOf(buffer[0]));

                return true;
            }

            return false;
        }

        private INPUT[] CreateMouseInput()
        {
            INPUT[] buffer = new INPUT[1];
            buffer[0].type = INPUT_MOUSE;
            PointF smoothedCursor = CursorSmoother.getSmoothedCursor();
            buffer[0].mi.dx = (int)(smoothedCursor.X * 65535.0f / screenWidth);
            buffer[0].mi.dy = (int)(smoothedCursor.Y * 65535.0f / screenHeight);
            buffer[0].mi.mouseData = 0;
            buffer[0].mi.dwFlags = MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE;
            buffer[0].mi.time = 0;
            buffer[0].mi.dwExtraInfo = (IntPtr)0;
            return buffer;
        }

    }
}
