using System;
using System.Collections.Generic;
using System.Text;
using WiimoteLib;
using System.Runtime.InteropServices;
using WiiDesktop.Exceptions;

namespace WiiDesktop.Domain.Handlers.Keyboard
{
    class KeyboardHandler : EventHandler
    {
        public const byte VK_TAB = 0x09;
        public const byte VK_MENU = 0x12; // VK_MENU is Microsoft talk for the ALT key
        public const byte VK_SPACE = 0x20;
        public const byte VK_RETURN = 0x0D;
        public const byte VK_LEFT = 0x25;
        public const byte VK_UP = 0x26;
        public const byte VK_RIGHT = 0x27;
        public const byte VK_DOWN = 0x28;
        public const int KEYEVENTF_EXTENDEDKEY = 0x01;
        public const int KEYEVENTF_KEYUP = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void keybd_event(byte bVk, byte bScan, long dwFlags, long dwExtraInfo);


        public KeyboardHandler(EventHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        override protected bool InnerHandle(WiimoteState currentState, WiimoteState lastState)
        {
            bool handled = true;

            if (!lastState.ButtonState.A && currentState.ButtonState.A)
                throw new UserTerminatedException();
            else if (!lastState.ButtonState.B && currentState.ButtonState.B)
                keybd_event(VK_SPACE, 0x45, 0, 0);
            else if (lastState.ButtonState.B && !currentState.ButtonState.B)
                keybd_event(VK_SPACE, 0x45, KEYEVENTF_KEYUP, 0);
            else if (!lastState.ButtonState.Up && currentState.ButtonState.Up)
                keybd_event(VK_UP, 0x45, 0, 0);
            else if (lastState.ButtonState.Up && !currentState.ButtonState.Up)
                keybd_event(VK_UP, 0x45, KEYEVENTF_KEYUP, 0);
            else if (!lastState.ButtonState.Down && currentState.ButtonState.Down)
                keybd_event(VK_DOWN, 0x45, 0, 0);
            else if (lastState.ButtonState.Down && !currentState.ButtonState.Down)
                keybd_event(VK_DOWN, 0x45, KEYEVENTF_KEYUP, 0);
            else if (!lastState.ButtonState.Left && currentState.ButtonState.Left)
                keybd_event(VK_LEFT, 0x45, 0, 0);
            else if (lastState.ButtonState.Left && !currentState.ButtonState.Left)
                keybd_event(VK_LEFT, 0x45, KEYEVENTF_KEYUP, 0);
            else if (!lastState.ButtonState.Right && currentState.ButtonState.Right)
                keybd_event(VK_RIGHT, 0x45, 0, 0);
            else if (lastState.ButtonState.Right && !currentState.ButtonState.Right)
                keybd_event(VK_RIGHT, 0x45, KEYEVENTF_KEYUP, 0);
            else
                handled = false;

            return handled;
        }
    }
}
