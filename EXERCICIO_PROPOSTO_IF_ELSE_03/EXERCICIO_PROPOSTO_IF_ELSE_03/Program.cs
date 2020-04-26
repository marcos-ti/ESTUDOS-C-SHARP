using System;

namespace EXERCICIO_PROPOSTO_IF_ELSE_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ESCREVA EM ORDEM CRESCENTE OU DECRESCENTE DOIS NÚMEROS INTEIROS: ");

            String[] NUMEROS = Console.ReadLine().Split(' ');
            int A = int.Parse(NUMEROS[0]);
            int B = int.Parse(NUMEROS[1]);

            if (A % 2 == 0  &&  B % 2 == 0)
            {
                Console.WriteLine("OS NÚMEROS " + A + " E " + B + " SÃO MULTIPLOS!");
            }
            else
            {
                Console.WriteLine("OS NÚMEROS " + A + " E " + B + " NÃO SÃO MULTIPLOS!");

            }
        }
    }
}
