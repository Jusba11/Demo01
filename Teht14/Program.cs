using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pisteet = new int[6];
            int i,j, luku;

            do
            {
                Console.Write("syottamalla -1 ohjelma tulostaa jakauman arvosanoista. Anna arvosana >");
                string syote = Console.ReadLine(); // luetaan käyttäjän syöte
                luku = int.Parse(syote);

                switch (luku)
                {
                    case 0: pisteet[0] = pisteet[0] + 1; break;
                    case 1: pisteet[1] = pisteet[1] + 1; break;
                    case 2: pisteet[2] = pisteet[2] +  1; break;
                    case 3: pisteet[3] = pisteet[3] + 1; break;
                    case 4: pisteet[4] = pisteet[4] + 1; break;
                    case 5: pisteet[5] = pisteet[5] + 1; break;
                    case -1: break;
                    default: Console.WriteLine("Virhe. Ei validi luku."); break;
                }

            } while (luku != -1); // luku -1 lopettaa loopin.


            // tehdään jakauma.
            for (i = 0; i < 6; i++)
            {
                Console.Write(i);
                Console.Write(": ");

                for (j = 0; j < pisteet[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
