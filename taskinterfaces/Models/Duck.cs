using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskinterfaces.Interfaces;

namespace taskinterfaces.Models
{
    internal class Duck: IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying.");
        }
        public void Swim()
        {
            Console.WriteLine("Duck is swimming.");
        }
    }
}