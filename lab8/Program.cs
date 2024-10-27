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

        /// <summary>
        /// get 1/sqrt(x)
        /// </summary>
        /// <param name="x">parametr >= 0</param>
        /// <returns></returns> 
        public double GetSqrt(double x)
        {
            if (x <= 0.2) return 0;
            double y0 = 1 / x;
            double y1 = 3 * y0 / 2 - x * y0 * y0 * y0 / 2;
            while (Math.Abs(y1 - y0) > eps)
            {
                y0 = y1;
                y1 = 3 * y0 / 2 - x * y0 * y0 * y0 / 2;
            }
            return Math.Abs(y1);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
