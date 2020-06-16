using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace BookStore.ErrorHandling
{
    static class ExceptionLogger
    {
        /// <summary>
        /// Writes the exception to logs.txt file and possibly display it in MessageBox
        /// </summary>
        /// <param name="exceptionToLog">Exception to log into file.</param>
        /// <param name="display">If true displays the exception to MessageBox</param>
        public static void Log(Exception exceptionToLog,bool display=true)
        {
            FileInfo fileInfo = new FileInfo("logs.txt");
            if(!fileInfo.Exists)
            {
                fileInfo.Create().Close();
            }
            using(StreamWriter streamWriter=new StreamWriter(fileInfo.FullName,true))
            {
                streamWriter.WriteLine(DateTime.Now.ToString());
                streamWriter.Write("Source:" + exceptionToLog.Source.ToString()+" ");
                streamWriter.WriteLine("Message:" + exceptionToLog.Message.ToString());
                if (display)
                {
                    MessageBox.Show(exceptionToLog.Source + exceptionToLog.Message);
                }
            }
        }
    }
}
