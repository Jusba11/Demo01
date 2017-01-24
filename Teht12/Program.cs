using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[5];
            int i, luku;

            for (i = 0; i < luvut.Length; i++)
            {
                Console.Write("Anna luku >");
                string syote = Console.ReadLine(); // luetaan käyttäjän syöte
                luku = int.Parse(syote);
                luvut[i] = luku;
            }
            
            Console.Write("luvut olivat: ");

            for (i = 4; i >= 0; i--)
            {
                Console.Write(luvut[i]); // jottei tuli ylimääräistä pilkkua loppuun.
                if (i > 0)
                {
                    Console.Write(","); 
                }
            }
        }
    }
}
