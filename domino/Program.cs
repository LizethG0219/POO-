using System;

namespace domino
{
    class Domino
    {
        public int a;
        public int b;

        public Domino(int A, int B)
        {
            a = A;
            b = B;
        }
        public static int operator +(Domino dom1, Domino dom2)
        {
            return (dom1.a + dom2.a + dom1.b + dom2.b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Domino A = new Domino(2, 0);
            Domino B = new domino (5, 3);
            Console.WriteLine("La suma del domino es: "( A+ B));
        }
    }
}
