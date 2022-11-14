using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dogamegoldas
{
    class Program
    {
        static void Main(string[] args)

            //adatok.txt
            //4
            //5
            //23
            //6
            //7
            //10
            //11
            //23
            //67
            //3


        {
            Console.WriteLine("\"adatok.txt\" fájl feldolgozása......");

            StreamReader be = new StreamReader("adatok.txt");

            int[] szamok = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int szam = Convert.ToInt32(be.ReadLine());
                szamok[i] = szam;
            }


            be.Close();

            // számok összegének

            int szum = 0;

            foreach (var sz in szamok)
            {
                szum = szum + sz;
            }

            Console.WriteLine($"Számok összege: {szum}");

            // 5-el vagy 3-al osztható számok

            Console.WriteLine("5-el vagy 3-al osztható számok:");

            foreach (var sz in szamok)
            {
                if (sz % 5 == 0 || sz % 3 == 0)
                {
                    Console.WriteLine(sz);
                }
            }

            Console.WriteLine("\n--**--**--\n");

            //parban.txt
            //75; 18
            //27; 16
            //81; 89
            //40; 96
            //62; 63
            //5; 32
            //7; 22
            //3; 99
            //25; 46
            //79; 86


            Console.WriteLine("\"parban.txt\" fájl feldolgozása......");

            StreamReader be2 = new StreamReader("parban.txt");

            Console.WriteLine("Számok különbsége:");

            for (int i = 0; i < 10; i++)
            {
                string[] adatok = be2.ReadLine().Split(';');
                int szam1 = Convert.ToInt32(adatok[0]);
                int szam2 = Convert.ToInt32(adatok[1]);

                Console.WriteLine(szam1 - szam2);
            }

            be2.Close();
            Console.ReadKey();
        }
    }
}
