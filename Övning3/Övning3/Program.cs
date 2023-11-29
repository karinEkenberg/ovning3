﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deklaration av variabler
            Random slumpat = new Random(); // skapar ett random objekt
            int speltal = slumpat.Next(); // anropar Next metoden för att skapa ett slumptal mellan 1 och 20
            // läs på, vad är overload metoder? https://msdn.microsoft.com/en-us/library/system.random.next(v=vs.110).aspx
            bool spela = true; // Variabel för att kontrollera om spelet ska fortsätta köras

            while (spela)
            {
                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");
                int tal = Convert.ToInt32(Console.ReadLine());

                if (tal < speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för litet, försök igen.");
                }

                if (tal > speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen."); // syntax fel, lägger till ett + som saknas
                }

                if (tal == speltal) // syntax fel, det saknades ett = 
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                spela = false;

            }
        }
    }
}
