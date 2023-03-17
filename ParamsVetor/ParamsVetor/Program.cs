using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum( 2, 3 );
            int s2 = Calculator.Sum( 4, 5 );

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
