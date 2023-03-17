using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Retangulo
{
    internal class Formula
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return (Altura + Largura) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            return " Area: " + Area().ToString("F2",CultureInfo.InvariantCulture)
            + " Perímetro: " + Perimetro().ToString("F2",CultureInfo.InvariantCulture)
            +" Diagonal: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
