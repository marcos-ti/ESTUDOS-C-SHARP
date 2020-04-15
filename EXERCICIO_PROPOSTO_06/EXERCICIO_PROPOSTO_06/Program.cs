using System;
using System.Globalization;

namespace EXERCICIO_PROPOSTO_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, areaTri, pi = 3.14159, areaCirc, areaTrap, areaQuad, areaRet;

            Console.WriteLine("DIGITE OS VALORES DE A, B E C COM ESPAÇOS:");
            String[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);
            areaTri = (A * C)/2;
            Console.WriteLine("A área do triângulo retângulo que tem A por base e C por altura é: "
             +  areaTri.ToString("F3", CultureInfo.InvariantCulture));
            areaCirc = pi * (Math.Pow(C, 2));
            Console.WriteLine("A área do círculo de raio C. (pi = 3.14159) é: " 
            + areaCirc.ToString("F3", CultureInfo.InvariantCulture));
            areaTrap = ((A + B)/2 * C);
            Console.WriteLine("A área do trapézio que tem A e B por bases e C por altura é: "
            + areaTrap.ToString("F3", CultureInfo.InvariantCulture));
            areaQuad = Math.Pow(B, 2);
            Console.WriteLine("A área do quadrado que tem lado B é: "
            + areaQuad.ToString("F3", CultureInfo.InvariantCulture));
            areaRet = A * B;
            Console.WriteLine("A área do retângulo que tem lados A e B é: "
            + areaRet.ToString("F3", CultureInfo.InvariantCulture));
            

        }
    }
}
