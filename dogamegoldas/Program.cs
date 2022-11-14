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
        {
            Console.WriteLine("\"adatok.txt\" fájl feldolgozása......");

            StreamReader be = new StreamReader("adatok.txt");


            be.Close();
            Console.ReadKey();
        }
    }
}
