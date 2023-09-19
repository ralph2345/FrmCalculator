using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmCalculator1
{
    public delegate T Formula <T>(T arg1, T arg2); 
    internal class CalculatorClass
    {
        public Formula<string> info;

        public double GetSum(double x , double y)
        {
            return x + y;
        }

        public double GetDifference(double x, double y)
        {
            return x - y;
        }

        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added delegates");
            }

            remove
            {
                Console.WriteLine("Remove delegates");
            }
        }

        public double GetProduct(double x, double y)
        {
            return x * y;
        }

        public double GetQuotient(double x, double y)
        {
            return x / y;
        }


    }
}
