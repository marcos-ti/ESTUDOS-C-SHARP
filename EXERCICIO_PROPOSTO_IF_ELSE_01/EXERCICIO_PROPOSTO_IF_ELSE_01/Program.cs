using System;

namespace EXERCICIO_PROPOSTO_IF_ELSE_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("ESCREVA UM NÚMERO INTEIRO:");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("O número " + num1 + " é par!");
            }
            else
            {
                Console.WriteLine("O número " + num1 + " é impar!");
            }


        }
    }
}
