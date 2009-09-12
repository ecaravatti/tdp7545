using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WiiDesktop.Controller;
using WiiDesktop.View;
using WiiDesktop.Exceptions;
using System.Threading;

namespace WiiDesktop
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            bool retry = true;

            while (retry)
            {
                try
                {
                    VirtualDesktop model = new VirtualDesktop();
                    //model.StartDesktop();
                    //retry = false;
                    //Application.EnableVisualStyles();
                    //Application.SetCompatibleTextRenderingDefault(false);
                    //Application.Run(new MainScreen(model));
                    Application.Run(new GesturesScreen());
                }
                catch (UserTerminatedException)
                {
                    DialogResult result = MessageBox.Show(ErrorMessages.WIIMOTE_NOT_FOUND + "\n" + ErrorMessages.PLEASE_CONNECT_WIIMOTE,
                                                          "Wiimote no detectado", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    retry = result.Equals(DialogResult.Retry);
                }
            }
        }

    }
}