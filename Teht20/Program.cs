using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht20
{
    class Program
    {
        static void Main(string[] args)
        {

            // Melkosen hieno laskuri jolla voi selvittää kahvimäärän jolla selviää ohjelmoinnintunneista heleposti!
            // Ajanpuutteen vuoksi ei mikään hurjimmasta päästä toimintansa puolesta. Mutta kiistatta toimiva peli.

            int uni;

            Console.WriteLine("Ohjelma kertoo younesi maaran perusteella sen paljonko kahvia tarvitsee varata ohjelmoinnin tunneille. \n");
            Console.Write("Ilmoita nukkumasi aika kokonaisina tunteina > ");
            string syote = Console.ReadLine();
            uni = int.Parse(syote);

            if (uni == 0)
            {
                Console.WriteLine("Kannattaa vissii ottaa keitin mukaan..");
            }

            else if (uni > 0 && uni <= 3)
            {
                Console.WriteLine("Huhhuh. Pista semmoset 2L");
            }

            else if (uni > 3 && uni <= 5)
            {
                Console.WriteLine("Jaajaa, saattaa parjata suunnilleen 4 kupilla.");
            }
            else if (uni > 5 && uni <= 8)
            {
                Console.WriteLine("Jepjep kylla se kuppi riittanee etta kaynnistyy.");
            }
            else if (uni > 8 && uni <= 10)
            {
                Console.WriteLine("Ota ny kuppi varulta vaikka ootki nukkunu hienosti.");
            }
            else if (uni > 10)
            {
                Console.WriteLine("Joo kahvi on heikoille uni kunniaan!");
            }
        }
    }
}
