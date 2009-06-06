using System.Collections.Generic;
using System.Text;
using WiimoteLib;
using WiiDesktop.Domain.Cursor;
using WiiDesktop.Domain.Handlers;
using WiiDesktop.Domain.Handlers.Mouse;
using WiiDesktop.Domain.Handlers.Keyboard;
using WiiDesktop.Exceptions;

namespace WiiDesktop.Controller
{
    class WiimoteController
    {
        private WiimoteState lastState;
        private EventHandler eventHandler;

        public WiimoteController(int screenWidth, int screenHeight)
        {
            this.lastState = new WiimoteState();            
            
            EventHandler keyboardHandler = new KeyboardHandler(null);
            EventHandler mouseUpHandler = new MouseUpHandler(keyboardHandler);
            EventHandler mouseDragHandler = new MouseDragHandler(mouseUpHandler, screenWidth, screenHeight);
            this.eventHandler = new MouseDownHandler(mouseDragHandler, screenWidth, screenHeight);
        }


        public void StartHandling(WiimoteState currentState)
        {
            eventHandler.Handle(currentState, lastState);
            SetLastState(currentState);
        }

        private void SetLastState(WiimoteState currentState)
        {
            lastState.IRState.Found1 = currentState.IRState.Found1;
            lastState.IRState.RawX1 = currentState.IRState.RawX1;
            lastState.IRState.RawY1 = currentState.IRState.RawY1;
            lastState.ButtonState.A = currentState.ButtonState.A;
            lastState.ButtonState.B = currentState.ButtonState.B;
            lastState.ButtonState.Down = currentState.ButtonState.Down;
            lastState.ButtonState.Up = currentState.ButtonState.Up;
            lastState.ButtonState.Left = currentState.ButtonState.Left;
            lastState.ButtonState.Right = currentState.ButtonState.Right;
        }
    }
}
