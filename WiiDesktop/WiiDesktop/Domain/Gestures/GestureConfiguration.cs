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
        private const string FILE_PATH = @"c:\Users\Laura\Desktop\gesturesConfig.txt";

        #region Privates Methods
       
        private GestureConfiguration()
        {
            InitializeMap();
        }

        private void InitializeMap()
        {
            if (configMap == null)
            {
                configMap = new Dictionary<MouseGesture, string>();
                if (ExistsConfiguration())
                    FillMapFromFile();
            }
        }

        private void FillMap()
        {
            configMap = new Dictionary<MouseGesture, string>();
            configMap.Add(MouseGesture.Down, "calc.exe");
            configMap.Add(MouseGesture.Up, "iexplore.exe");
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
            // Specify file, instructions, and privelegdes
            FileStream file = new FileStream(FILE_PATH, FileMode.OpenOrCreate, FileAccess.Write);
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
            PropertiesReader propertiesReader = new PropertiesReader(FILE_PATH);
            foreach (DictionaryEntry item in propertiesReader)
            {
                Debug.Write(item.Key.ToString() + "=" + item.Value.ToString());
                MouseGesture mouseGesture = (MouseGesture)Enum.Parse(typeof(MouseGesture), item.Key.ToString());
                configMap.Add(mouseGesture, item.Value.ToString());
            }

        }

        public bool ExistsConfiguration() 
        {
            return File.Exists(FILE_PATH);
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
