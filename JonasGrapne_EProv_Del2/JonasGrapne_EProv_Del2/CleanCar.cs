using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonasGrapne_EProv_Del2
{
    class CleanCar : Car
    {
        public CleanCar()
        {
            passengers = generator.Next(1, 3);
            contrabandAmount = 0;
        }
    }
}
