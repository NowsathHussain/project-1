using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(Sum(a,b));
            Console.WriteLine(Interest(10000,5,10));

        }
        #region functions
        public static int Sum(int a,int b)
        {
            return a + b;
        }
        #endregion
        #region simPleInterest
        public static double Interest(int a, int b, int c)
        {
            return a * b * c / 100.0;
        }
        #endregion
    }
}
