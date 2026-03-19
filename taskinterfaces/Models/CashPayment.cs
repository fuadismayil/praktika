using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskinterfaces.Interfaces;

namespace taskinterfaces.Models
{
    internal class CashPayment: IPayment
    {
        public double amount { get; set; }


        public double Pay(double amount)
        {
            Console.WriteLine($"{amount} AZN negd olaraq odenis edildi, Tarix:{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
            return amount;
        }
    }
}