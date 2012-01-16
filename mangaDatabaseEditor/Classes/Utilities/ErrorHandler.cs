using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace mangaDbEditor.Classes.Utilities
{
    internal class ErrorHandler
    {
        /// <summary>
        /// This methods logs every runtime error at the specied file.
        /// </summary>
        public static void LogError(Exception ex)
        {
            try
            {
                Stream stream = new FileStream(Application.StartupPath + "\\editor_error.log", FileMode.Append);
                using (StreamWriter fWriter = new StreamWriter(stream))
                {
                    fWriter.WriteLine(DateTime.Now + "\n");
                    fWriter.WriteLine();
                    fWriter.Write(ex.ToString());
                    fWriter.WriteLine(Environment.NewLine);
                }
                stream.Close();
                stream.Dispose();
            }
            catch (Exception iException)
            {
                Debug.WriteLine(iException);
            }
        }
    }
}