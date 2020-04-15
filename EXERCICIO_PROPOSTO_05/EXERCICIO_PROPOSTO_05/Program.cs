using System;
using System.Globalization;

namespace EXERCICIO_PROPOSTO_05
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Digite o código, o número e o valor unitário das peças (1): ");

            int cod1, cod2, num2, num1;
            double val1, val2, valTotal;

            string[] valores = Console.ReadLine().Split(' ');//DECLAREI A STRING VALORES
            cod1 = int.Parse(valores[0]);
            num1 = int.Parse(valores[1]);
            val1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            ///////

            Console.WriteLine("Digite o código, o número e o valor unitário das peças (2): ");

            valores = Console.ReadLine().Split(' ');//CHAMEI A STRING JÁ DECLARADA
            cod2 = int.Parse(valores[0]);
            num2 = int.Parse(valores[1]);
            val2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valTotal = (val1 * num1) + (val2 * num2);

            Console.WriteLine("O valor a ser pago é: R$" + valTotal.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
