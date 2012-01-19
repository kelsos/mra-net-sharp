using System;
using System.IO;

namespace mranetwpf.Classes.Utilities
{
    internal class ErrorHandler
    {
        public static bool LogErrors { get; set; }
        public static bool DisplayErrorWindow { get; set; }
        private static string LogPath { get; set; }

        public static void HandleException (Exception ex)
        {
            if(LogErrors)
            {
                LogError(ex);
            }
            if(DisplayErrorWindow)
            {
                DisplayErrorDialog(ex);
            }

            
        }
        
        private static void DisplayErrorDialog(Exception ex)
        {
            
        }

        /// <summary>
        /// This methods logs every runtime error at the specied file.
        /// </summary>
        /// <param name="exe">The exception to log.</param>
        private static void LogError(Exception exe)
        {
            try
            {
                using(Stream stream = new FileStream("mra-wpf-error.log", FileMode.Append))
                using (var fW = new StreamWriter(stream))
                {
                    fW.WriteLine(DateTime.Now);
                    fW.Write(exe.Message);
                    fW.WriteLine();
                }
            }
            catch (Exception ex)
            {
               // ErrorMessageBox.Show(ex.Message, ex.ToString());
            }
        }
    }
}