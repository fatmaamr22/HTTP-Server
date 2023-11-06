using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HTTPServer
{
    class Logger
    {
        //static StreamWriter sr = new StreamWriter("log.txt");
        public static void LogException(Exception ex)
        {
            // TODO: Create log file named log.txt to log exception details in it
            //Datetime:
            //message:
            // for each exception write its details associated with datetime 
            
            var date = DateTime.Now.ToShortDateString();
            using (var tw = new StreamWriter("log.txt", true))
            {
                tw.WriteLine("Datetime:" + date + ", message:" + ex.Message);
            }
        }
    }
}
