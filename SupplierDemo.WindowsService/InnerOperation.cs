using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SupplierDemo.WindowsService
{
    public class InnerOperation
    {
        Timer timer = new Timer();
        public void Start()
        {
            WriteToFile("Service Başladı " + DateTime.Now);
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 5000;
            timer.Enabled = true;
        }
        public void Stop()
        {
            WriteToFile("Service Durduruldu " + DateTime.Now);
        }
        public void WriteToFile(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
            if (!File.Exists(filepath))
            {
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            string[] files = Directory.GetFiles(@"C:\Users\faksa\source\repos\SupplierDemo\SupplierDemo.WebUI\XMLBackUP");
            foreach (string file in files)
            {
                if (File.Exists(file))
                {
                    if (File.GetCreationTime(file) < DateTime.Now.AddMinutes(-1))
                    {
                        try
                        {
                            string fileName = Path.GetFileName(file);
                            File.Delete(file);
                            WriteToFile("" + fileName + " Silindi ");
                        }
                        catch (Exception ex)
                        {
                            WriteToFile("" + ex.Message.ToString() + "");
                        }
                       
                    }
                }
            }

        }

    }
}
