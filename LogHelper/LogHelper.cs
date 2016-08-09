using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogHelper
{
    public class LogHelper
    { // Log errors in a text document
        public string Location { get { return @"D:\\SeleniumWebdriverLog.txt"; } }
        public LogHelper()
        {
            if (!File.Exists(Location))
            {
                File.Create(Location);
            }
        }

        public void LogError(Exception ee)
        {
            using (StreamWriter writer = new StreamWriter(Location, true))
            {
                writer.WriteLine("Message : " + ee.Message + "<br/>" + Environment.NewLine + "StackTrace :" + ee.StackTrace + "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);
            }
        }
        public static void Main()
        {
            LogHelper hlp = new LogHelper();
        }
    }

}
