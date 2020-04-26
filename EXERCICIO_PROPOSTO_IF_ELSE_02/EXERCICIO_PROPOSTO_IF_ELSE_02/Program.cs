using System;

namespace EXERCICIO_PROPOSTO_IF_ELSE_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ESCREVA UM NÚMERO INTEIRO: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 >= 0)
            {
                Console.WriteLine("O NÚMERO " + num1 + " É NÃO NEGATIVO!");
            }
            else
            {
                Console.WriteLine("O NÚMERO " + num1 + " É NEGATIVO!");
            }
        }
    }
}
