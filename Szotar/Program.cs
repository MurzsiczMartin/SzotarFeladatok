using System;
using System.IO;

namespace Szotar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string fajlnev = @"..\..\..\szotar.txt";
                string[] sorok = File.ReadAllLines(fajlnev);
                Console.WriteLine("A fájl sorainak száma: {0}", sorok.Length);

                Console.WriteLine("Adjon meg egy kezdőbetűt!");
                string kb = Console.ReadLine();

                foreach (string szo in sorok)
                {
                    if (szo.StartsWith(kb))
                    {
                        Console.WriteLine(szo);
                    }
                }

                //a megfelelő sorszámú szó kiírása
            }
            catch (Exception hiba)
            {
                Console.WriteLine("Sajnos hiba történt a fájl megnyitása közben!");
                Console.WriteLine(hiba.Message); ;
            }
               
        }
    }
}
