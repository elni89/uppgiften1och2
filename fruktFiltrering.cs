using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    public class filterMetod
    {
        // Metod för att filtrera och returnera frukter vars namn börjar med bokstaven A eller a
        public List<string> FiltreradeFrukterMedA(string[] inputArray)
        {
            List<string> Filtrerad = new List<string>(); // Skapar en lista för filtrerade frukter

            foreach (string s in inputArray)
            {
                // Kollar om fruktens namn börjar med stor eller liten bokstav A
                if (s.StartsWith("A") || s.StartsWith("a"))
                {
                    Filtrerad.Add(s); // Lägger till frukten i listan om den börjar med A eller a
                }
            }

            return Filtrerad; // Returnerar den filtrerade listan med frukter
        }
    }
}