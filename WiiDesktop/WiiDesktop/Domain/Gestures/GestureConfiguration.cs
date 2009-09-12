using System;
using System.Collections.Generic;
using System.Text;
using MouseGestures;
using System.IO;
using System.Diagnostics;
using WiiDesktop.Common;
using System.Collections;

namespace WiiDesktop.Domain.Gestures
{
    public class GestureConfiguration
    {
        // Members
        private Dictionary<MouseGesture, String> configMap;
        private static GestureConfiguration instance = new GestureConfiguration();
        private const string GESTURES_FILE_NAME = "gestures.dat";
        private const string POWER_POINT = "POWERPNT.EXE";

        #region Privates Methods
       
        private GestureConfiguration()
        {
            InitializeMap();
        }

        private void FillPPTDefault() 
        {
            configMap.Add(MouseGesture.LeftDown, POWER_POINT);
        }

        private void InitializeMap()
        {
            if (configMap == null)
            {
                configMap = new Dictionary<MouseGesture, string>();
                if (ExistsConfiguration())
                    FillMapFromFile();
            }
            if (!configMap.ContainsKey(MouseGesture.LeftDown))
                FillPPTDefault();

        }

        private Dictionary<MouseGesture, String> Clone()
        {
            Dictionary<MouseGesture, String> clone = new Dictionary<MouseGesture, String>();

            foreach (KeyValuePair<MouseGesture, String> item in configMap)
            {
                clone.Add(item.Key, item.Value);
            }

            return clone;
        }

        #endregion
        
        public static GestureConfiguration Instance{
            get { return instance; }
        }

        public void SaveConfiguration()
        {
            // Creates directory if it not exists
            if (!Directory.Exists(Settings.CONFIGURATION_DATA_PATH))
            {
                Directory.CreateDirectory(Settings.CONFIGURATION_DATA_PATH);
            }

            // Specify file, instructions, and privelegdes
            FileStream file = new FileStream(Settings.CONFIGURATION_DATA_PATH + GESTURES_FILE_NAME,
                                             FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);
            foreach (KeyValuePair<MouseGesture, String> item in configMap)
            {
                sw.WriteLine(item.Key + "=" + item.Value);
            }
            sw.Close();
            file.Close();
        }

        public Dictionary<MouseGesture, String> GetConfiguration() 
        {
            return configMap;
        }

        public void FillMapFromFile()
        {
            configMap.Clear();
            PropertiesReader propertiesReader = new PropertiesReader(Settings.CONFIGURATION_DATA_PATH + GESTURES_FILE_NAME);
            foreach (DictionaryEntry item in propertiesReader)
            {
                Debug.Write(item.Key.ToString() + "=" + item.Value.ToString());
                MouseGesture mouseGesture = (MouseGesture)Enum.Parse(typeof(MouseGesture), item.Key.ToString());
                configMap.Add(mouseGesture, item.Value.ToString());
            }

        }

        public bool ExistsConfiguration() 
        {
            return File.Exists(Settings.CONFIGURATION_DATA_PATH + GESTURES_FILE_NAME);
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

        public Dictionary<MouseGesture, String> GetConfigurationCopy() 
        {
            return Clone();
        }
        
    }
}
