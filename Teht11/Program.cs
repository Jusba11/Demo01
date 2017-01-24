using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, luku;

            Console.Write("Anna luku >");
            string syote = Console.ReadLine(); // luetaan käyttäjän syöte
            luku = int.Parse(syote);


            for (i = 1; i < (luku+1); i++) //luku+1 siksi että tulee oikea määrä tähtiä.
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
             
        }
    }
}
