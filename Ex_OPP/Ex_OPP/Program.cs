using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_OPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dados x = new Dados();
            Dados y = new Dados();

            

            Console.WriteLine("Dados do primeiro Funcionário: ");

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            x.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Console.WriteLine("Dados do segundo Funcionário: ");

            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario_medio = (x.Salario + y.Salario) / 2.0;


            Console.WriteLine("O salário medio é = " +salario_medio.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
