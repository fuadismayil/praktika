using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskinterfaces.Interfaces;

namespace taskinterfaces.Models
{
    public class Car:IVehicle
    {
        public string Brand { get; set ; }

        public void Drive()
        {
            Console.WriteLine($"{Brand} is driving.");
        }
    }
}