using System;
using System.Globalization;

namespace EXERCICIO_PROPOSTO_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE O VALOR DO RAIO DE UM CÍRCULO: ");
            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159;
            //double area = pi * (raio * raio);//PODE USAR O METODO MATH.POW
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine("A ÁREA DA CIRCUNFERÊNCIA É: " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
