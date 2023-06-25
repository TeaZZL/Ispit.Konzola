using Ispit.Konzola.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    public class PametniTelefon : IPametniTelefon, ITelefon
    {
        public string Model { get; private set; }
        public PametniTelefon(string model)
        {
            Model = model;
        }

        public string Surfanje(string url)
        {
            if (ProvjeriAkoJeValidanUrl(url))
            {
                Console.WriteLine("URL je ispravan i možete surfati na njemu! ");
                return "OK";
            }
            else
            {
                Console.WriteLine("URL nije ispravan! ");
                return "NOT OK";
            }

        }

        public string Poziv(string telefonski_broj)
        {
            if (ProvjeriAkoJeValidanBroj(telefonski_broj))
            {
                Console.WriteLine("Telefonski broj je ispravan i možete ga zvati! ");
                return "OK";
            }
            else
            {
                Console.WriteLine("Telefonski broj nije ispravan! ");
                return "NOT OK";
            }
        }

        public bool ProvjeriAkoJeValidanUrl(string url)
        {
            foreach (char c in url)
            {
                if (c >= '0' && c <= '9')
                {
                    return false;
                }
            }
            return true;

        }

        public bool ProvjeriAkoJeValidanBroj(string telefonski_broj)
        {

            foreach (char c in telefonski_broj)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
