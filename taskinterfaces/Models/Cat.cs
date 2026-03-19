using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskinterfaces.Interfaces;

namespace taskinterfaces.Models
{
    public class Cat:IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Miyaou") ;
        }


    }
}