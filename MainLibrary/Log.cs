using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MainLibrary
{
    public class Log
    {
        public static void WriteLog(string message)
        {
            if (!Directory.Exists(@"C:\HostelLog"))
                Directory.CreateDirectory(@"C:\HostelLog");
            if (!File.Exists(@"C:\HostelLog\log.txt"))
                File.AppendAllText(@"C:\HostelLog\log.txt", "");
            StreamWriter sw = new StreamWriter(@"C:\HostelLog\log.txt",true,System.Text.Encoding.UTF8);
            sw.WriteLine(DateTime.Now.ToString("dd.MM HH:mm:ss")+" "+message);
            sw.Dispose();
            sw.Close();
        }
    }
}
