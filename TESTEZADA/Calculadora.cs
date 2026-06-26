using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTEZADA
{
    public class Calculadora
    {
        public static double Somar(double a, double b)
        {
            return a + b;
        }

        public static double Subtrair(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public static double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            return a / b;
        }

        public static string ConverterBinario(int numero)
        {
            return Convert.ToString(numero, 2);
        }

        public static long Fatorial(int numero)
        {
            long resultado = 1;

            for (int i = 1; i <= numero; i++)
                resultado *= i;

            return resultado;
        }

        public static double Seno(double numero)
        {
            return Math.Sin(numero);
        }

        public static double Cosseno(double numero)
        {
            return Math.Cos(numero);
        }

        public static double Tangente(double numero)
        {
            return Math.Tan(numero);
        }
    }
}
