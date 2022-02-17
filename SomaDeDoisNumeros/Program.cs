using System;

namespace SomaDeDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("digite o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            Soma(num1, num2);
        }

        public static float Soma(float num1, float num2)
        {
            float result;

            result = num1 + num2;
            Console.WriteLine("resultado da soma dos números : {0}", result);
            return result;
        }


    }
}
