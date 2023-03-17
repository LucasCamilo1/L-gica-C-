using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOPP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int calc;
            Calculator.Calc(a,out calc);
            Console.WriteLine(calc);
            
        }
    }
}
