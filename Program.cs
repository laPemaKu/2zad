using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string korisnik;
            korisnik = Console.ReadLine();
            korisnik = korisnik.Replace(" ", "_");
            Console.WriteLine(korisnik);

            Console.ReadKey();

        }
    }
}
