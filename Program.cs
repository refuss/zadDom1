using System;
using System.Drawing;
using System.Security.Cryptography;

namespace zadania1
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad. 1
            Console.Write("Nazywam się Łukasz Sulikowski. " + "Mam 32 lata.\r\n");
            string powitanie = "Nazywam się Łukasz Sulikowski";
            Console.WriteLine(powitanie);
            Console.WriteLine();
            //Console.ReadKey();

            //zad. 2
            //Nie wiem czym jest zestaw 0 ale metodologia jest prosta więc pomijam ^^

            //zad.3
            //To samo co wcześniej

            //zad. 4
            double l1 = 0.52;
            double l2 = 1.14;
            double r1 = l1 + l2;
            double r2 = l1 - l2;
            double r3 = l1 * l2;
            //double r4 = l1 / l2;
            Console.WriteLine("Wyniki: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dodawanie: " + $"{l1} + {l2} = {r1}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Odejmowanie: " + r2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Mnożenie: " + r3);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Dzielenie: " + l1 / l2);
            Console.WriteLine();
            //Console.ReadKey();

            //zad. 5
            Console.Write("Podaj pierwszą liczbę: ");
            string n1 = Console.ReadLine();
            double c1 = Int32.Parse(n1);
            Console.Write("\n");
            Console.Write("Podaj drugą liczbę: ");
            string n2 = Console.ReadLine();
            double c2 = Int32.Parse(n2);
            Console.Write("\n");
            Console.WriteLine("Wyniki: ");
            Console.WriteLine("Dodawanie: " + $"{c1} + {c2} = {c1 + c2}");
            Console.WriteLine("Odejmowanie: " + $"{c1} - {c2} = {c1 - c2}");
            Console.WriteLine("Mnożenie: " + $"{c1} * {c2} = {c1 * c2}");
            Console.WriteLine("Dzielenie: " + $"{c1} / {c2} = {c1 / c2}");
            Console.ReadKey();

            //zad. 6
            //Praktycznie napisałem rozwiązanie w poprzednim zadaniu. W związku z czym jest dla mnie to zrozumiałe.

            Console.WriteLine("Dziękuję za uwagę i miłego dnia :)");
        }
    }
}
