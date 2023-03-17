using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Formula f = new Formula();

            Console.WriteLine("Digite a altura do retângulo: ");
            f.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Largura: ");
            f.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine(" " + f);
        }
    }
}
