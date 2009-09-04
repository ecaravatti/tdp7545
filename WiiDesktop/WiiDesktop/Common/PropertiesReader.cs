using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace WiiDesktop.Common
{

    /// <summary>
	/// PropertyReader reads in a Java style properties file.  This is read into
	/// a Hashtable.
	/// </summary>
	public class PropertiesReader : Hashtable
	{
        /// <summary>
        /// Reads in the properties file one line at a time and processes it
        /// </summary>
        /// <param name=\"fileName\"></param>
		public PropertiesReader(string fileName){
            using (StreamReader reader = File.OpenText(fileName)) {
                string input = null;
                while ((input = reader.ReadLine()) != null) {
                    ProcessLine(input);
                }
                reader.Close();
            }
		}

        /// <summary>
        /// Reads in the line from the text file and splits it into 2 parts.  If there are
        /// more \"=\" symbols in the text, only the first one is used as a separator. 
        /// </summary>
        /// <param name=\"input\"></param>
        protected void ProcessLine(string input) {
            string[] pair = input.Split(new char[] {'='}, 2);
            if (pair[0] != null && pair[0] != String.Empty)
            {
                Add(pair[0].Trim(), pair[1].Trim());
            }
        }
    }
}
