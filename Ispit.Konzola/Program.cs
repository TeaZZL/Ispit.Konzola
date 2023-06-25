using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    public class Program
    {
        static void Main(string[] args)
        {
            PametniTelefon pametniTelefon = new PametniTelefon("Xiaomi");
            TestirajTelefon(pametniTelefon);
        }

        private static void TestirajTelefon(PametniTelefon telefon)
        {
            Console.Write("Unesite telefonski broj bez razmaka: ");
            var telBroj = Console.ReadLine();

            Console.Write("Unesite URL: ");
            var url = Console.ReadLine();

            telefon.Poziv(telBroj);
            telefon.Surfanje(url);
        }
    }
}
