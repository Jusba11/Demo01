﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht08
{
    class Program
    {
        static void Main(string[] args)
        {

            int luku1, luku2, luku3, suurin;

            Console.Write("Anna 1. luku >");
            string syote = Console.ReadLine();
            luku1 = int.Parse(syote);

            Console.Write("Anna 2. luku >");
            syote = Console.ReadLine();
            luku2 = int.Parse(syote);

            Console.Write("Anna 3. luku >");
            syote = Console.ReadLine();
            luku3 = int.Parse(syote);

            suurin = luku1; // alkuun laitetaan eka luku muka suurimmaksi jotta voidaan lähteä vertaamaan

            if (luku2 > suurin)
            {
                suurin = luku2;
            }

            if (luku3 > suurin)
            {
                suurin = luku3;
            }

            Console.Write("Suurin luvuista oli: ");
            Console.WriteLine(suurin);

        }
    }
}
