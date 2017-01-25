using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht19
{
    class Program
    {
        static void Main(string[] args)
        {
            int oikein = 0, hp = 10, i, j, gameOn = 1;
            char[] sana = { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' }; //olutpanimo

            Console.WriteLine("Sanassa on " + sana.Length + " kirjainta. \n");

            do
            {
                Console.Write("Veikkaa kirjain > ");
                string syote = Console.ReadLine();

                switch (syote)
                {
                    case "o": {
                            if (sana[0] == 'O' || sana[9] == 'o')
                            {
                                Console.Clear();
                                Console.WriteLine("Kirjain löydetty jo!");
                            }
                            else
                            {
                                oikein = oikein + 2; // 2 koska tulee kaksi kirjainta samalla kertaa.
                                Console.Clear();
                                Console.WriteLine("JEPULIS!");
                                sana[0] = 'O';//eka ja vika kirjain o.
                                sana[9] = 'o';
                            }
                            break;
                        }
                    case "l":
                        {
                            if (sana[1] == 'l')
                            {
                                Console.Clear();
                                Console.WriteLine("Kirjain löydetty jo!");
                            }
                            else
                            {
                                oikein++;
                                Console.Clear();
                                Console.WriteLine("JEPULIS!");
                                sana[1] = 'l';
                            }
                            break;
                        }
                    case "u":
                        {
                            if (sana[2] == 'u')
                            {
                                Console.Clear();
                                Console.WriteLine("Kirjain löydetty jo!");
                            }
                            else
                            {

                                oikein++;
                                Console.Clear();
                                Console.WriteLine("JEPULIS!");
                                sana[2] = 'u';
                            }
                            break;
                        }
                    case "t":
                        {
                            if (sana[3] == 't')
                            {
                                Console.Clear();
                                Console.WriteLine("Kirjain löydetty jo!");
                            }
                            else
                            {
                                oikein++;
                                Console.Clear();
                                Console.WriteLine("JEPULIS!");
                                sana[3] = 't';
                            }
                            break;
                        }
                    case "p":
                        {
                            if (sana[4] == 'p')
                            {
                                Console.Clear();
                                Console.WriteLine("Kirjain löydetty jo!");
                            }
                            else
                            {
                                oikein++;
                                Console.Clear();
                                Console.WriteLine("JEPULIS!");
                                sana[4] = 'p';
                            }
                            break;
                        }
                    case "a":
                        {
                            if (sana[5] == 'a')
                            {
                                Console.Clear();
                                Console.WriteLine("Kirjain löydetty jo!");
                            }
                            else
                            {
                                oikein++;
                                Console.Clear();
                                Console.WriteLine("JEPULIS!");
                                sana[5] = 'a';
                            }
                            break;
                        }
                    case "n":
                        {
                            if (sana[6] == 'n')
                            {
                                Console.Clear();
                                Console.WriteLine("Kirjain löydetty jo!");
                            }
                            else
                            {

                                oikein++;
                                Console.Clear();
                                Console.WriteLine("JEPULIS!");
                                sana[6] = 'n';
                            }
                            break;
                        }
                    case "i":
                        {
                            if (sana[7] == 'i')
                            {
                                Console.Clear();
                                Console.WriteLine("Kirjain löydetty jo!");
                            }
                            else
                            {
                                oikein++;
                                Console.Clear();
                                Console.WriteLine("JEPULIS!");
                                sana[7] = 'i';
                            }
                            break;
                        }
                    case "m":
                        {
                            if (sana[8] == 'm')
                            {

                                Console.Clear();
                                Console.WriteLine("Kirjain löydetty jo!");
                            }
                            else
                            {
                                oikein++;
                                Console.Clear();
                                Console.WriteLine("JEPULIS!");
                                sana[8] = 'm';
                            }
                            break;
                        }

                    default:
                        {
                            hp--;
                            Console.Clear();
                            Console.WriteLine("NOUP!"); break;

                        }

                }

                // printtaa sanan nykyisessä vaiheessaan näytölle.
                for (j = 0; j < sana.Length; j++)
                {
                    Console.Write(" " + sana[j] + " ");
                }

                Console.WriteLine("Arvauksia jaljella " + hp + " kappaletta!");
                Console.WriteLine("Kirjaimia oikein " + oikein + "/ 10");
                
                if (hp == 0 || oikein == 10)
                {
                    gameOn = 0;
                }
                
            } while (gameOn == 1);

            // peli loppuu.. game over.

            Console.Clear();
            Console.WriteLine("GAME OVER!");

            Console.WriteLine("Arvauksia jaljella " + hp + " kappaletta!");
            Console.WriteLine("Kirjaimia oikein " + oikein + "/ 10");

            for (j = 0; j < sana.Length; j++)
            {
                Console.Write(" " + sana[j] + " ");
            }

            Console.WriteLine();
        }
    }
}
