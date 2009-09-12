using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Microsoft.Win32;
using System.Diagnostics;

namespace WiiDesktop.Domain.Gestures
{
    public class ApplicationsFinder 
    {
        public static IList<String> GetAvailableApplications() 
        {
            string registryKey = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(registryKey);
            Process[] processlist = Process.GetProcesses();
            ManagementClass managmentClass = new ManagementClass("Win32_process");
            IList<String> applications = new List<String>();

            applications.Add("Seleccione uno...");
            foreach (ManagementObject obj in managmentClass.GetInstances())
            {
                applications.Add(obj.GetPropertyValue("Caption").ToString());
            }
            applications.Add("POWERPNT.exe");

            return applications;
        }
    }
}
