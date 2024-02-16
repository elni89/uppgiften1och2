using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv ut en meddelande för användaren att välja mellan alternativ 1 eller 2
            Console.WriteLine("Dags att filtrera, välj 1 eller 2");
            var bokstavsVal = Console.ReadLine();

            switch (bokstavsVal)
            {
                case "1":
                    // Kod att utföra om användaren väljer alternativ 1
                    // Skapar en instans av filterMetod för att kunna använda metoden FiltreradeFrukterMedA
                    filterMetod class1 = new filterMetod();

                    // Ber användaren skriva in olika frukter separerade med kommatecken och sparar inmatningen som en sträng
                    Console.WriteLine("Skriv in alla olika frukter, separera dem med (,)");
                    string frukter = Console.ReadLine();
                    string[] allaFrukter = frukter.Split(',');

                    // Använder metoden FiltreradeFrukterMedA från instansen av filterMetod för att filtrera frukter som börjar med bokstaven A
                    List<string> filtreradLista = class1.FiltreradeFrukterMedA(allaFrukter);

                    // Skapar en katalog/mapp med namnet "FolderA" där filen kommer att sparas
                    string fruktmap = Directory.CreateDirectory("AllaFrukterMedA").FullName;

                    // Sammanfogar sökvägen till den nya filen med namnet "frukterMedA.txt" inuti det skapade katalogen
                    string filePath = Path.Combine(fruktmap, "frukterMedA2.txt");

                    // Sparar den filtrerade listan av frukter som en textfil i den skapade katalogen
                    File.WriteAllLines(filePath, filtreradLista);

                    // Skriver ut meddelande till användaren om att alla frukter som börjar på bokstaven A har sparats i en textfil
                    Console.WriteLine("Alla frukter som startar på bokstaven A har sparats i en textfil som heter 'frukterMedA'");
                    break;

                case "2":
                    // Kod att utföra om användaren väljer alternativ 2
                    egenBosktav egenBokstav = new egenBosktav();

                    // Ber användaren ange en bokstav för att filtrera namn
                    Console.WriteLine("Ange en bokstav för att filtrera namn:");
                    var InmatadBokstav = Console.ReadLine().ToUpper();

                    egenBokstav.X = InmatadBokstav;

                    // Ber användaren skriva in olika namn separerade med kommatecken och sparar inmatningen som en sträng
                    Console.WriteLine($"Skriv in alla namnen, {InmatadBokstav} använd (,) för att seperera");
                    string namn = Console.ReadLine();
                    string[] allaNamn = namn.Split(',');

                    // Använder metoden FiltreradeNamnEgenBokstav från instansen av egenBosktav för att filtrera namn med den angivna bokstaven
                    List<string> filtreradNamnLista = egenBokstav.FiltreradeNamnEgenBokstav(allaNamn);

                    // Skapar en katalog/mapp med namnet "XFolder" där filen kommer att sparas
                    string xMappen = Directory.CreateDirectory("XFolder").FullName;

                    // Sammanfogar sökvägen till den nya filen med namnet "NamnMed{InmatadBokstav}.txt" inuti det skapade katalogen
                    string xMappenNamn = Path.Combine(xMappen, $"NamnMed{InmatadBokstav}.txt");

                    // Sparar den filtrerade listan av namn som en textfil i den skapade katalogen
                    File.WriteAllLines(xMappenNamn, filtreradNamnLista);

                    // Skriver ut meddelande till användaren om att alla namn som börjar på den angivna bokstaven har sparats i en textfil
                    Console.WriteLine($"Alla namn som startar på bokstaven {InmatadBokstav} har sparats i en textfil som heter 'NamnMed{InmatadBokstav}.txt'");
                    break;

                default:
                    Console.WriteLine("Ogiltigt val. Vänligen välj 1 eller 2.");
                    break;
            }

        }
    }
}