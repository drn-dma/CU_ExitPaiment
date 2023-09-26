using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Windows;

namespace CU_ExitPaiment.Classes
{
    internal class Logger
    {
        public static void WriteLog(Exception e, string message)
        {
            string logPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CU_App";
            string textFilePath = logPath + "\\logs.txt";

            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CU_App"))
            {
                using (StreamWriter sw = new StreamWriter(textFilePath, true))
                {
                    sw.WriteLine($"{DateTime.Now} : {message} ---->> {e.Message}");
                }
            }
            else
            {
                Directory.CreateDirectory(logPath);

                using (StreamWriter sw = new StreamWriter(textFilePath, true))
                {
                    sw.WriteLine($"{DateTime.Now} : {message} ---->> {e.Message}");
                }

            }


        }
    }
}
