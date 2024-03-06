using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, resultado;
            string operacao;

            Console.WriteLine("Vamos iniciar os cálculos: ");

            Console.Write("Escolha o primeiro valor: ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Escolha o segundo valor: ");
            n2 = float.Parse(Console.ReadLine());

            Console.Write("Escolha uma operação de multiplicação, divisão, soma ou subtração.\nResponda com *, / , + ou - respectivamente: ");
            operacao = Console.ReadLine();

            if (operacao == "*")
                resultado = n1 * n2;
            else if (operacao == "/")
                resultado = n1 / n2;
            else if (operacao == "+")
                resultado = n1 + n2;
            else
                resultado = n1 - n2;

            Console.WriteLine("O resultado é: " + resultado);

            Console.ReadKey();
        }
    }
}
