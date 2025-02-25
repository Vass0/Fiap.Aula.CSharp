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

            //Operações Relacionais
            Console.WriteLine("\n Comparação entre os números");
            Console.WriteLine($"Os números são iguais? {num1 == num2}");
            Console.WriteLine($"Os números são diferentes? {num1 != num2}");
            Console.WriteLine($"O primeiro é maior? { num1 > num2}");
            Console.WriteLine($"O primeiro é maior? {num1 < num2}");

            Console.WriteLine("\n Verificação Lógica:");

            bool ambosPositivo = num1 > 0 && num2 > 0;
            bool NegativoPositivo = num1 < 0 || num2 < 0;
            bool nenhumPositivo = !(num1 < 0 || num2 < 0);

            Console.WriteLine($"Ambos positivos {ambosPositivo}");
            Console.WriteLine($"Ao menos um positivo {NegativoPositivo}");
            Console.WriteLine($"Nanhum número Positivo {nenhumPositivo}");

            Console.WriteLine("\nDigite qualquer coisa para sair.");
            Console.ReadKey();

        }
    }
}
