using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_Objeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dados x = new Dados();
            Dados y = new Dados();

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Idade ");
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Idade ");
            y.Idade = int.Parse(Console.ReadLine());

            if (x.Idade > y.Idade)
            {
                Console.WriteLine("Pessoa mais velha: "+x.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + y.Nome);
            }

         

        }
    }
}
