using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜberladungMethoden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog Cooper = new Dog("Cooper", 8, "Fam. Dapper");
            Dog Buba = new Dog("Buba", 8);
            Cooper.WriteData();
            Buba.WriteData();
            Console.ReadKey();
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static double Sum(double[] numbers)
        {
            double result=0;
            foreach (double d in numbers)
            {
                result += d;
            }
            return result;
        }
    }
}
