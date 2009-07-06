using System;
using System.Collections.Generic;
using System.Text;
using MouseGestures;

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
            catch (ArgumentException e)
            {
                configMap.Remove(gesture);
                configMap.Add(gesture, application);
            }
        }
        
    }
}
