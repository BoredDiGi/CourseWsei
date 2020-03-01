using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInteractive
{
    class Program
    {
        const int WIEK_EMERYTALNY = 65;
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikacja Emerytura");

            Console.Write("PODAJ IMIĘ: ");
            var imie = Console.ReadLine().Trim().ToUpper(); //trim ucina spacje a upper powiększa litery
            
            Console.Write("Podaj NAZWISKO: ");
            var nazwisko = Console.ReadLine().Trim().ToUpper();

            // Console.WriteLine("Witaj, " + imie + " " + nazwisko + "!"); //konkatenacja stringów
            //Console.WriteLine("Witaj, {0} {1}!", imie, nazwisko); //string formater

            Console.WriteLine($"Witaj, {imie} {nazwisko}!"); //interpolated string

            Console.Write("Podaj swój wiek kochaniutki: ");

            //var napis = Console.ReadLine();
            //int wiek = int.Parse(napis); //zamiana typu danych

            int wiek = int.Parse(Console.ReadLine()); //zagnieżdżenie funkcji
            Console.WriteLine($"Masz {wiek} lat.");

            if (wiek >= WIEK_EMERYTALNY)
            {
                Console.WriteLine("Jesteś emerytem");
            }
            else
            {
                Console.WriteLine($"Do emerytury zostało Ci {WIEK_EMERYTALNY - wiek} lat!");
            }


        }
    }
}
