using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Logger
    {

        private static readonly Lazy<Logger> instance = new Lazy<Logger>(() => new Logger(), true);

        public string Filepath { get; set; }

        private Logger(string filepath = null)
        {
            if (String.IsNullOrEmpty(filepath))
                Filepath = Environment.CurrentDirectory + @"\Test.log";
        }

        public static Logger GetInstance()
        {
            return instance.Value;
        }

        public void WriteLog(string message)
        {
            try
            {
                File.AppendAllText(Filepath, message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
