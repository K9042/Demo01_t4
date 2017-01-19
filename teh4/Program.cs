using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teh4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ika;

            Console.Write("Anna ikäsi: ");
            ika = int.Parse(Console.ReadLine());

            if (ika < 18) Console.WriteLine("Alaikäinen.");
            else if (ika >= 18 && ika <= 65) Console.WriteLine("Täysi-ikäinen.");
            else Console.WriteLine("Seniori.");
        }
    }
}
