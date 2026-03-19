using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskinterfaces.Interfaces;

namespace taskinterfaces.Models
{
    internal class CardPayment: IPayment
    {
        public double amount { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public int CVV { get; set; }


        public double Pay(double amount)
        {
            Console.WriteLine($"{CardHolderName} terefinden **{CardNumber[^7..]} ile biten kartla {amount} AZN odenis edildi. Tarix:{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
            return amount;
        }
    }
}