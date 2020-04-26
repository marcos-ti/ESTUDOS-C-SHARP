using System;

namespace EXERCICIO_PROPOSTO_IF_ELSE_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE AS HORAS INICIAIS E FINAIS DE UM JOGO:");

            String[] HORAS = Console.ReadLine().Split(' ');
            int PRIMEIRA = int.Parse(HORAS[0]);
            int SEGUNDA = int.Parse(HORAS[1]);

            int CALCULO;
            if (PRIMEIRA < SEGUNDA)
            {
                CALCULO = SEGUNDA - PRIMEIRA;
            }
            else
            {
                CALCULO = (24 - PRIMEIRA) + SEGUNDA;
            }
            Console.WriteLine("O JOGO DUROU " + CALCULO + " HORA(S)");
        }
    }
}
