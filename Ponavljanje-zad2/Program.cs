using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strng;

            Console.WriteLine("Upisite niz znakova. ");
            strng = Console.ReadLine();

            Console.WriteLine(strng.Replace(' ', '_'));
            Console.ReadKey();
        }
    }
}
