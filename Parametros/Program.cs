using System;

namespace Parametros
{
    class parametros 
    {
        public static void Suma(int a)
        {
            a = a + 2;
            Console.WriteLine("El valor de a es: " + a);
        }
        public static void SumaTres(in int  a, out int b, in int c)
        {
            b = a + c;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6; int b; int c = 15;
            parametros.Suma(ref a);
            Console.WriteLine("Valor de a es: " +  a);
            parametros.SumaTres(in a, out b, in c);
            Console.WriteLine("Valor total es: " + b);
        }
        
    }
}
