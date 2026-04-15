using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("---CALCULADORA SENAI---");
            
            Console.Write("Digite o prímeiro numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double soma = num1 + num2;
            Console.WriteLine($"O resultado da soma é {soma}");
        }
    }
}