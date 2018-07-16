using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oefenreeks 1");
            Console.WriteLine("------------");
            Console.WriteLine("Naam Oefening: ToonGetallen1");
            Console.WriteLine("Verwacht Resultaat:");
            Console.WriteLine("1 2 3 4 5");
            Console.WriteLine("Jouw resultaat");
            Oef1_for.ToonGetallen1();
            Console.WriteLine("\n");
            Console.WriteLine("Naam Oefening: ToonGetallen2");
            Console.WriteLine("Verwacht Resultaat:");
            Console.WriteLine("1 2 3 4 5 6 7");
            Console.WriteLine("Jouw resultaat");
            Oef1_for.ToonGetallen2(7);
            Console.WriteLine("\n");
            Console.WriteLine("Naam Oefening: ToonGetallen3");
            Console.WriteLine("Verwacht Resultaat:");
            Console.WriteLine("10 9 8 7 6 5 4 3 2 1 0");
            Console.WriteLine("Jouw resultaat");
            Oef1_for.ToonGetallen3();
            Console.WriteLine("\n");
            Console.WriteLine("Naam Oefening: ToonGetallen4");
            Console.WriteLine("Verwacht Resultaat:");
            Console.WriteLine("0 10 20 30 40 50 \t\t\t");
            Console.WriteLine("Jouw resultaat");
            Oef1_for.ToonGetallen4();
            Console.WriteLine("\n");
            Console.WriteLine("Naam Oefening  \t Verwacht Resultaat \tJouw Resultaat");
            Console.WriteLine("BerekenSom1 \t 5050 \t\t\t" + Oef1_for.BerekenSom1());
            Console.WriteLine("BerekenSom2 \t 465 \t\t\t" + Oef1_for.BerekenSom2(30));
            Console.WriteLine("BerekenFac \t 362880 \t\t" + Oef1_for.BerekenFac(10));

            Console.Write("Verdergaan met Reeks 2? (Y/n)");
            if (Console.ReadKey().KeyChar == 'n') return;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Oefenreeks 2");
            Console.WriteLine("------------");

            Console.WriteLine("Naam Oefening  \t Verwacht Resultaat \tJouw Resultaat");
            Console.WriteLine("IsPriem \t\t True \t\t" + Oef2_for.IsPriem(19));
            Console.WriteLine("IsPriem \t\t False \t\t" + Oef2_for.IsPriem(15));
            Console.WriteLine("ZoekGgd \t\t 5 \t\t" + Oef2_for.ZoekGgd(15, 25));

            Console.ReadKey();
        }
    }
}
