using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojištění
{
    internal class Evidence
    {
        string jmeno;
        string prijmeni;
        private Databaze databaze;

        public Evidence()
        {
            databaze = new Databaze();
        }

        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("Dnes je: {0}", DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("---------------\nEvidence pojištěných\n---------------");
            Console.WriteLine();
        }
        public void PridejZaznam()
        {
            DateTime datumZalozan =DateTime.Now;
            DateTime datumNarozeni;
            int telCislo;
            ZadejUzivatele();

            Console.WriteLine("Zadejte datum narození ve tvaru [1.1.2012]:");
            while (!DateTime.TryParse(Console.ReadLine(), out datumNarozeni))
                Console.WriteLine("Chybné zadání, zadejte znovu: ");

            DateTime dnes = DateTime.Today;
            int vek = dnes.Year - datumNarozeni.Year;
            if (dnes < datumNarozeni.AddYears(vek))
                vek--;

            Console.WriteLine("Zadejte telefoní číslo:");
            while (!int.TryParse(Console.ReadLine(), out telCislo))
                Console.WriteLine("Neplatné číslo, zadejte znovu:");

            databaze.PridejZaznam(datumZalozan, jmeno, prijmeni, datumNarozeni, vek, telCislo);
        }
        public void VypisZaznamy()
        {
            Console.WriteLine();
            Console.WriteLine("Nalezeny tyto záznamy: ");
            databaze.VypisZaznamy();
        }

        public void VyhledejZaznamy()
        {
            ZadejUzivatele();
            List<Zaznam> zaznamy = databaze.NajdiZaznam(jmeno,prijmeni);

            if (zaznamy.Count() > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Nalezeny tyto záznamy: ");
                foreach (Zaznam z in zaznamy)
                    Console.WriteLine(z);
            }
            else
                Console.WriteLine("Nebyly nalezeny žádné záznamy.");
        }
        public void VymazZaznamy()

        {
            ZadejUzivatele();
            databaze.VymazZaznam(jmeno,prijmeni);
        }
        public void ZadejUzivatele()
        {
            Console.WriteLine();
            Console.WriteLine("Zadej jméno pojištěného:");
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Chybné zadání, zadejte znovu: ");
            }

            Console.WriteLine("Zadej příjmení pojištěného:");
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Chybné zadání, zadejte znovu: ");
            }
        }


    }
}

