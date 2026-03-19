using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskinterfaces.Interfaces;

namespace taskinterfaces.Models
{
    internal class FileLogger: ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[File]-[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}]: {message}");
        }
    }
}