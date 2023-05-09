using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVariablePrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.name = "감자";
            product1.price = 2000;
        }
    }
}
