using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exVector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE QUARTO");

            Console.WriteLine("Digite a quantidade de quartos: ");

            int n = int.Parse(Console.ReadLine());
            Cadastro[] vect = new Cadastro[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o e-mail: ");
                string email = Console.ReadLine();

                Console.WriteLine("Digite o quarto: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Cadastro(nome,email);

            }

            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

       
        }
    }
}
