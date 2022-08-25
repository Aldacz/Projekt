using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojištění
{
    internal class Databaze
    {
        private List<Zaznam> zaznamy;

        public Databaze()
        {
            zaznamy = new List<Zaznam>();
        }

        public void PridejZaznam(DateTime datumZalozani, string jmeno, string prijmeni, DateTime datumNarozeni, int vek, int telCislo)
        {
            zaznamy.Add(new Zaznam(datumZalozani, jmeno, prijmeni, datumNarozeni, vek, telCislo));
        }

        public List<Zaznam> NajdiZaznam(string hledaneJmeno, string hledanePrijmeni)
        {
            List<Zaznam> nalezene = new List<Zaznam>();
            foreach (Zaznam z in zaznamy)
            {
                if ((hledaneJmeno == z.Jmeno) && (hledanePrijmeni == z.Prijmeni))
                    nalezene.Add(z);
            }
            return nalezene;
        }

        public void VypisZaznamy()
        {
            foreach (Zaznam z in zaznamy)
            {
                Console.WriteLine(z);
            }
        }
        public void VymazZaznam(string hledaneJmeno, string hledanePrijmeni)
        {
            List<Zaznam> nalezeno = NajdiZaznam(hledaneJmeno, hledanePrijmeni);
            foreach (Zaznam z in nalezeno)
                zaznamy.Remove(z);
        }
    }
}
