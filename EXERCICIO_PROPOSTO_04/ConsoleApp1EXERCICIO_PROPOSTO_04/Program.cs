using System;
using System.Globalization;

namespace ConsoleApp1EXERCICIO_PROPOSTO_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu número de funcionário: ");
            int numFun = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite suas horas trabalhadas: ");
            int horasTrab = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que recebe por hora trabalhada: ");
            double valHora = double.Parse(Console.ReadLine());

            double soma = horasTrab * valHora;

            Console.WriteLine("Seus resultados são: " + "Funcionário Número: " + numFun);
            Console.WriteLine("Salário = R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
