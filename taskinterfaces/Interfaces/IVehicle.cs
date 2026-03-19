using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskinterfaces.Interfaces
{
    interface IVehicle
    {
        string Brand { get; set; }
        void Drive();
    }
}