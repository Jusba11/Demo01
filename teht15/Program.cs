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
            int luku, i, leveys, kerrokset = 1 ;

            Console.Write("Anna luku >");
            string syote = Console.ReadLine(); // luetaan käyttäjän syöte
            luku = int.Parse(syote);

            luku = luku - 3;         //miinustamalla 3 saadaan alimman kerroksen leveys
            leveys = (luku) * 2 + 1; // tästä kaavasta.
            

            Console.WriteLine(leveys);

            do // lasketaan kerrosten määrä
            {
                leveys = leveys - 2;
                kerrokset++;

            } while (leveys != 1);

            
            Console.WriteLine(kerrokset);

        }
    }
}
