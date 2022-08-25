using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojištění
{
    internal class Zaznam
    {
        public DateTime DatumZalozani { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int TelCislo { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public int Vek { get; set; }  

        public Zaznam(DateTime datumZalozani, string jmeno, string prijmeni, DateTime datumNarozeni, int vek, int telCislo)
        {
            DatumZalozani = datumZalozani;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelCislo = telCislo;
            DatumNarozeni = datumNarozeni;
            Vek = vek;
        }

        public override string ToString()
        {
            return String.Format("Jméno: {0}, Příjmení: {1}, Věk: {2}, Tel: {3}, Datum založení: {4}", Jmeno, Prijmeni, Vek, TelCislo, DatumZalozani);
        }
    }
}
