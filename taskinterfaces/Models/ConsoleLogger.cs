using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskinterfaces.Interfaces;

namespace taskinterfaces.Models
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Console]-[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}]: {message}");
        }
    }
}