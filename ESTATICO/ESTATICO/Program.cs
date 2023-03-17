using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ESTATICO
{
    internal class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
           

            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio); 

            Console.WriteLine("Circunferencia: "+ circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: "+ volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("PI: " + Calculadora.Pi);



        }

        
    }
}
