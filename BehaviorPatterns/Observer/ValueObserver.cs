using System;
using System.IO;

namespace Observer
{
    class ValueObserver : IObserver
    {
        public void OnChange(ClassA detector, string fileName)
        {
            if (!Directory.Exists($"{Environment.CurrentDirectory} //files"))
                Directory.CreateDirectory($"{Environment.CurrentDirectory} //files");
            File.AppendAllText(Environment.CurrentDirectory + $"//files//{fileName}.log", $"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} --- Value was set to {detector.Value}{Environment.NewLine}");
        }
    }
}
