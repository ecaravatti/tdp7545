using System;
using System.Collections.Generic;
using System.Text;
using WiimoteLib;
using WiiDesktop.Domain.Cursor;

namespace WiiDesktop.Domain.Handlers
{
    abstract class EventHandler
    {
        protected EventHandler nextHandler;

        protected void ContinueChain(WiimoteState currentState, WiimoteState lastState)
        {
            if (nextHandler != null) nextHandler.Handle(currentState, lastState);
        }

        public void Handle(WiimoteState currentState, WiimoteState lastState)
        {
            if (!InnerHandle(currentState, lastState))
            {
                ContinueChain(currentState, lastState);
            }
        }

        protected abstract bool InnerHandle(WiimoteState currentState, WiimoteState lastState);
    }
}
