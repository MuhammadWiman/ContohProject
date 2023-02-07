using System;

namespace belajar_Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            for ( int z = 0 ; z < 5 ; z++) {
                int a ;
                int b ;
                int c ;
                string Op;
                System.Console.WriteLine();
                System.Console.WriteLine("Welcome to Mobile calculator");
                System.Console.WriteLine();
                System.Console.Write("Masukan Nilai A : ");
                a = int.Parse(Console.ReadLine());
                System.Console.Write("Masukan Operator : ");
                Op = Console.ReadLine();
                System.Console.Write("Masukan Nilai B : ");
                b = int.Parse(Console.ReadLine());
                
                if (Op == "+") {
                    c = a + b ;
                    System.Console.WriteLine();
                    System.Console.WriteLine("Nilai C adalah : " + c);
                }
                else if (Op == "-") {
                    c = a - b ;
                    System.Console.WriteLine();
                    System.Console.WriteLine("Nilai C adalah : " + c);
                }
                else if (Op == "*") {
                    c = a * b ;
                    System.Console.WriteLine();
                    System.Console.WriteLine("Nilai C adalah : " + c);
                }
                else {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Operator tidak sesuai");
                }
            }
        }
    }
}
