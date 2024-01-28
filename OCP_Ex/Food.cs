using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Ex
{
    internal class Food : Product
    {
        public override double CalculateTax(double price)
        {
            double tax = price * 0.20;
            return tax;
        }
    }
}
