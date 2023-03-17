using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Quatro
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Entre com seu nome completo");

            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");

            int qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha) ");

            string[] vet = Console.ReadLine().Split(' ');
            string unome = vet[0];
            int idade  = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(qtd);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(unome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));




            
        


            
        }
    }
}
