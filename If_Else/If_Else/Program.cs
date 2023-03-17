using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Digite um número e falaremos se é Positivo ou negativo: ");
            int x = int.Parse(Console.ReadLine());

            if(x < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("Positivo");
            } Final do exercício 01 
            ------------------------------------------------------------------------------------------------
            */

            /* Console.WriteLine("Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar");

             int x = int.Parse(Console.ReadLine());

             if(x % 2 != 1)
             {
                 Console.WriteLine("Par");
             }
             else
             {
                 Console.WriteLine("Impar");
             } Final do exercício 02 
            ------------------------------------------------------------------------------------------------
            */

            Console.WriteLine("Digite o primeiro número: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite o segundo número e direi se são múltiplos, ou não: ");
            int y = int.Parse(Console.ReadLine());

            if (x % y == 0 || y % x == 0)
            {
                Console.WriteLine("São Multiplos ");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }

        }
    }
}
