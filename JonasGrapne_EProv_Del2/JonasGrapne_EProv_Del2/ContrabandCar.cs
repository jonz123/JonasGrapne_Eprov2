using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonasGrapne_EProv_Del2
{
    class ContrabandCar : Car
    {
        public ContrabandCar()
        {
            passengers = generator.Next(1, 4);
            contrabandAmount = generator.Next(0, 4);
        }
    }
}
