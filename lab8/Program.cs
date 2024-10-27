using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    /// <summary>
    /// Calculate 1/sqrt(x)
    /// </summary>
    public class FuncCalc
    {
        protected double eps = 0.1;

        public FuncCalc(double e)
        {
            eps = Math.Abs(e);
        }

        public double Eps
        {
            get
            {
                return eps;
            }

            set
            {
                eps = Math.Abs(value);
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
