using System;

namespace EXERCICIO_PROPOSTO_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE O VALOR INTEIRO DE A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE O VALOR INTEIRO DE B: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE O VALOR INTEIRO DE C: ");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE O VALOR INTEIRO DE D: ");
            int D = int.Parse(Console.ReadLine());
            int ProdutoDif = ((A * B) - (C * D));
            Console.WriteLine("A DIFERENÇA DO PRODUTO DE A E B, PELO PRODUTO DE C E D É: "
                + ProdutoDif);
        }
    }
}
