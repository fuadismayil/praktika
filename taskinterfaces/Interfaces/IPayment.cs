using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskinterfaces.Interfaces
{
    interface IPayment
    {
        double amount { get; set; }
        double Pay(double amount);

    }
}