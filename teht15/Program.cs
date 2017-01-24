using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht15
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku, i, j, k, leveys, safeLeveys, kerrokset = 1;

            Console.Write("Anna luku >");
            string syote = Console.ReadLine(); // luetaan käyttäjän syöte
            luku = int.Parse(syote);

            luku = luku - 3;         //miinustamalla 3 saadaan alimman kerroksen leveys
            leveys = (luku) * 2 + 1; // tästä kaavasta.
            safeLeveys = (luku) * 2 + 1;
            /*
            Console.Write("Leveys: ");
            Console.WriteLine(leveys);
            */

            do // lasketaan kerrosten määrä
            {
                leveys = leveys - 2;
                kerrokset++;

            } while (leveys != 1);

            /*
            Console.Write("Kerrosten maara: ");
            Console.WriteLine(kerrokset);
            */

            // latvaan tarvittavien välilyöntien määrä = leveys / 2 - 1
            //seuraaviin tarvittavat välilyönnit = leveys / 2 - 2,3,4...
            
            for (i = 0; i < kerrokset; i++)
            {
                for (j = kerrokset; j > i; j--)
                {
                    Console.Write(" ");
                }
                
                for (k = 0; k < i * 2 + 1; k++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            } // tässä vaiheessa kuusi on piirretty, enää jalka puuttuu..
            
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < safeLeveys / 2 + 1; j++)
                {      /*           ^  Alkuperäinen leveys johon ei ole koskettu*/
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }


        }
    }
}
