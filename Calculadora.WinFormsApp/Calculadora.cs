using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.WinFormsApp
{
    public class Calculadora
    {
        public double Somar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            if(num2 == 0)
            {
                throw new DivideByZeroException("Não pode ser divido por 0");
            }
            return num1 / num2;
        }
    }
}
