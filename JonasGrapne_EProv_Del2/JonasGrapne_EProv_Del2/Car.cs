using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonasGrapne_EProv_Del2
{
    class Car
    {
        public int passengers;
        public int contrabandAmount;
        public bool alreadyChecked;
        public static Random generator = new Random();
        public int sneakyContraband = 0;


        public bool Examine()
        {
            alreadyChecked = true;

            int i = generator.Next(0, contrabandAmount);
            if (i == contrabandAmount) //Desto fler contraband, desto större chans att checken missar och returnar false
            {
                
            }
            else
            {
                return false;
            }

            if (contrabandAmount > 0)
            {
                sneakyContraband = generator.Next(1, contrabandAmount);
                if (contrabandAmount == sneakyContraband) //Desto fler contraband, desto större chans att checken missar och returnar false
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
