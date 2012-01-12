using System;
using System.IO;
using mraSharp.Forms;

namespace mraSharp.Classes
{
    internal class Logger
    {
        /// <summary>
        /// This methods logs every runtime error at the specied file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="errorText">The error text.</param>
        public static void ErrorLogger(string fileName, string errorText)
        {
            try
            {
                Stream stream = new FileStream(fileName, FileMode.Append);
                using (var fW = new StreamWriter(stream))
                {
                    fW.WriteLine(DateTime.Now + "\n");
                    fW.Write(errorText);
                    fW.WriteLine("\n");
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
            }
        }
    }
}