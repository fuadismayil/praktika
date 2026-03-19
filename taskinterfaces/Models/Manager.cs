using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskinterfaces.Interfaces;

namespace taskinterfaces.Models
{
    internal class Manager : IWorker, ISalary
    {
        public string Name { get; set; }
        public Manager(string name)
        {
            Name = name;
        }
        public double GetSalary()
        {
            return 5000.0;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is managing the project");
        }
    }
}