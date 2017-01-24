using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht16
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int veikkaukset = 0, arvaus, luku = rnd.Next(0, 100);
            
            do
            {
                Console.Write("Arvaa luku >");
                string syote = Console.ReadLine(); // luetaan käyttäjän syöte
                arvaus = int.Parse(syote);
                
                if (arvaus < luku)
                {
                    Console.WriteLine("Luku on isompi!");
                    veikkaukset++;
                }

                else if (arvaus > luku)
                {
                    Console.WriteLine("Luku on pienempi!!");
                    veikkaukset++;
                }

            } while (arvaus != luku);

            Console.WriteLine("OIKEIN!!! MUCHOS NACHOS! Veikkasit vain " + veikkaukset + " kertaa!");
        }


    }
}
