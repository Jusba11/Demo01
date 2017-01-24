using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht17
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] taulu1 = { 10, 20, 30, 40, 50 };
            int[] taulu2 =   { 5, 15, 25, 35, 45 };
            int[] taulu3 = new int[taulu1.Length + taulu2.Length]; // ak8ustetaan kolmas taulu jonka pituus on taulu1+taulu2 jotta kaikki arvot mahtuu.
            int i, j;

            for (i=0;i<taulu1.Length ;i++)
            {
                taulu3[i] = taulu1[i];
            }
            
            for (i=5; i < taulu3.Length; i++)
            {
                taulu3[i] = taulu2[(i-5)];
            }
            
            Array.Sort(taulu3);
            
            // TAULUKON 1 TULOSTUS
            i = 0;
            Console.Write("Luvut taulukossa 1: ");
            foreach (int luku in taulu1)
            {
                if (i == 4) // pitää huolen että viimeisen numeron jälkeen ei tule pilkkua!
                {
                    Console.Write(luku);
                    Console.WriteLine();
                }
                else
                {
                    i++;
                    Console.Write(luku + ", ");
                }
            }

            // TAULUKON 2 TULOSTUS
            i = 0; 
            Console.Write("Luvut taulukossa 2: ");
            foreach (int luku in taulu2)
            {
                if (i == 4) // pitää huolen että viimeisen numeron jälkeen ei tule pilkkua!
                {
                    Console.Write(luku);
                    Console.WriteLine();
                }
                else
                {
                    i++;
                    Console.Write(luku + ", ");
                }
            }
            
            // YHDISTETTY TAULUKKO TULOSTUS
            i = 0;
            Console.Write("Luvut yhdistettyna taulukossa: ");
            foreach (int luku in taulu3)
            {
                if (i == 9) // pitää huolen että viimeisen numeron jälkeen ei tule pilkkua!
                { 
                    Console.Write(luku);
                    Console.WriteLine();
                }
                else {
                    i++;
                    Console.Write(luku + ", ");
                }
            }

            /*
            for (i = 0; i < taulu3.Length; i++)
            {
                if (i == 9)
                {
                    Console.Write(taulu3[i]);
                }
                else
                {
                    Console.Write(taulu3[i] + ", ");
                }
            }
            */


            Console.WriteLine();
            
        }
    }
}
