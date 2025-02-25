using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Operacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu Nome");

            string nome = Console.ReadLine();

            Console.WriteLine("Digite um número");
            double num1 =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("DIgite outro Numero");

            Double num2 = double.Parse(Console.ReadLine());

            double soma = num1 + num2;
            double sub = num1 - num2;
            double mult = num1 * num2;
            double modulo = num1 % num2;
            
            Console.WriteLine("\n Resultados das Op aritm:");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Sub: {sub}");
            Console.WriteLine($"Multi: {mult}");
            Console.WriteLine($"Módulo: {modulo}");

            Console.ReadKey();
        }
    }
}
