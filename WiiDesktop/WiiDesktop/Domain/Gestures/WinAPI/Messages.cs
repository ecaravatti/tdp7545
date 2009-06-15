using System;
using System.Collections.Generic;
using System.Text;

namespace WinAPI {
  /// <summary>
  /// Defines Window Messages codes
  /// </summary>
  /// <remarks>
  /// Window Messages codes are defined in the WinUser.h file (Platform SDK)
  /// </remarks>
  public enum MessageCodes:int {
    /// <summary>
    /// The LEFT_BTN_DOWN message is posted when the user presses the right mouse button 
    /// </summary>
    /// 
    LEFT_BTN_DOWN = 0x0201,
    /// <summary>
    /// The LEFT_BTN_UP message is posted when the user releases the right mouse button 
    /// </summary>
    LEFT_BTN_UP = 0x0202,

    /// <summary>
    /// The WM_MOUSEMOVE message is posted to a window when the cursor moves.
    /// </summary> 
    WM_MOUSEMOVE = 0x0200,

    HC_ACTION = 0
  }
}
