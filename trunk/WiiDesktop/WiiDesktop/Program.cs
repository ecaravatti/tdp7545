using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WiiDesktop.Controller;
using WiiDesktop.View;

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
            try
            {
                //VirtualDesktop vd = new VirtualDesktop();
                //vd.StartDesktop();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainScreen());
            }
            catch(Exception x)
            {
                Console.WriteLine("Exception: " + x.Message);
            }
		}
	}
}