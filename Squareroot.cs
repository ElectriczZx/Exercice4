using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;


namespace Exercice4
{
    class Squareroot
    {

        double num;
        public void setNumber(double nb)
        {
            num = nb;
        }
        
        public double getSqrt()
        {
            return Math.Sqrt(num);
        }
        public double getNumber()
        {
            return num;
        }

    }
}
