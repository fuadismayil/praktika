using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskinterfaces.Interfaces;

namespace taskinterfaces.Models
{
    internal class Developer : IWorker, ISalary
    {
        public string Name { get; set; }
        public Developer (string name)
        {
            Name = name;
        }



        public double GetSalary()
        {
            return 2500.0;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working on project");
        }
    }
}