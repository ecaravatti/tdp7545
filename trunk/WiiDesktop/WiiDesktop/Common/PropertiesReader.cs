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
            using (StreamReader re = File.OpenText(fileName)) {
                string input = null;
                while ((input = re.ReadLine()) != null) {
                    ProcessLine(input);
                }
            }
		}

        /// <summary>
        /// Reads in the line from the text file and splits it into 2 parts.  If there are
        /// more \"=\" symbols in the text, only the first one is used as a separator.  If the
        /// line begins with a \"#\" symbol, then that line is a comment.  Comments are skipped.
        /// </summary>
        /// <param name=\"input\"></param>
        protected void ProcessLine(string input) {
            // Break the line into a key value pair.  We separate on the first = symbol
            string[] pair = input.Split(new char[] {'='}, 2);
            if (null != pair[0])
            {
                Add(pair[0].Trim(), pair[1].Trim());
            }
        }
    }
}
