using System;
using System.Collections.Generic;
using System.Text;
using MouseGestures;
using System.IO;
using System.Diagnostics;

namespace WiiDesktop.Domain.Gestures
{
    public class GestureConfiguration
    {
        private Dictionary<MouseGesture, String> configMap;
        private static GestureConfiguration instance = new GestureConfiguration();

        private GestureConfiguration() {
            FillMap();
        }

        public static GestureConfiguration Instance{
            get { return instance; }
        }

        public void SaveConfiguration()
        {
            // Specify file, instructions, and privelegdes
            FileStream file = new FileStream(@"c:\Users\Laura\Desktop\gesturesConfig.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);
            foreach (KeyValuePair<MouseGesture, String> item in configMap)
            {
                sw.WriteLine(item.Key + "=" + item.Value);
                //Debug.Write(item.Key + "-" + item.Value);
            }
            sw.Close();
            file.Close();

        }

        private void FillMap() 
        {
            configMap = new Dictionary<MouseGesture, string>();
            configMap.Add(MouseGesture.Down, "calc.exe");
            configMap.Add(MouseGesture.Up, "iexplore.exe");
        }

        public string ResolveCommand(MouseGesture mGesture) 
        {
            string command = String.Empty;
            configMap.TryGetValue(mGesture, out command);

            return command;
        }

        public void UpdateCommand(MouseGesture gesture, String application) 
        {
            try
            {
                configMap.Add(gesture, application);
            }
            catch (ArgumentException)
            {
                configMap.Remove(gesture);
                configMap.Add(gesture, application);
            }
        }
        
    }
}
