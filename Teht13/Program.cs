using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pisteet = new int[5];
            int i, luku, pienin, suurin, summa = 0, kokonais;

            for (i = 0; i < 5; i++)
            {
                Console.Write("Anna pisteet >");
                string syote = Console.ReadLine(); // luetaan käyttäjän syöte
                luku = int.Parse(syote);
                pisteet[i] = luku;
            }

            pienin = pisteet[0];

            for (i = 0; i < 5; i++) // etsitään pienin luku.
            {
                if (pisteet[i] < pienin)
                {
                    pienin = pisteet[i];
                }
            }

            suurin = pisteet[0];

            for (i = 0; i < 5; i++) // etsitään suurin luku.
            {
                if (pisteet[i] > suurin)
                {
                    suurin = pisteet[i];
                }
            }

            for (i = 0; i < 5; i++) // etsitään pienin luku.
            {
                summa = summa + pisteet[i];
            }

            kokonais = summa - pienin - suurin;

            Console.Write("Kokonaispisteet ovat: ");
            Console.WriteLine(kokonais);

        }
    }
}
