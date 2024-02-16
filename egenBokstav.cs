using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    public class egenBosktav
    {
        public string X { get; set; } // Egenskap för att lagra bokstaven

        public List<string> FiltreradeNamnEgenBokstav(string[] inputArray)
        {
            List<string> xFiltrerad = new List<string>(); // Skapar en lista för filtrerade namn

            // Loopar igenom varje namn i inputArray
            foreach (string name in inputArray)
            {
                // Kontrollerar om namnet börjar med bokstaven X (oavsett stor eller liten bokstav) efter att eventuella mellanslag tagits bort
                if (name.Trim().StartsWith(X, StringComparison.OrdinalIgnoreCase))
                {
                    xFiltrerad.Add(name); // Lägger till namn som börjar med X i listan xFiltrerad
                }
            }

            return xFiltrerad; // Returnerar den filtrerade listan
        }
    }
}