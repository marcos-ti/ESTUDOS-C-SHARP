using System;

namespace EXERCICIO_PROPOSTO_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE UM NÚMERO INTEIRO: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE OUTRO NÚMERO INTEIRO: ");
            int num2 = int.Parse(Console.ReadLine());
            int soma = num1 + num2;
            Console.WriteLine("A SOMA DOS NÚMEROS INTEIROS DIGITADOS É: " + soma);
        }
    }
}
