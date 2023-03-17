﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");

            Console.WriteLine($"{idade} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine($"Medida com 8 casas decimais: {medida:F8} ");
            Console.WriteLine($"Arrendodado (três casas decimais): {medida:F3} ");

            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3",CultureInfo.InvariantCulture));
           
        
            
        }
    }
}
