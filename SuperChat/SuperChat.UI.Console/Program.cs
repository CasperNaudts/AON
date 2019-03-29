using System;
using System.Diagnostics;
using System.Linq;

namespace SuperChat.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welkom");
            System.Console.WriteLine("Wilt U een bericht encrypteren (E) of decrypteren(D)");

            string choise = System.Console.ReadLine();
            string[] posibleChoises = {"encrypteren", "E", "e", "decrypteren", "d", "D"};
            while (!posibleChoises.Contains(choise))
            {
                System.Console.WriteLine("Geen geldige keuze.");
                System.Console.WriteLine("Wilt U een bericht encrypteren (E) of decrypteren(D)");

                choise = System.Console.ReadLine();
            }

            if (choise == "e" || choise == "E" || choise == "encrypteren")
            {
                
            }
        }
    }
}
