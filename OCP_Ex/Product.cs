using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Ex
{
    internal abstract class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public abstract double CalculateTax(double price);
    }
}
