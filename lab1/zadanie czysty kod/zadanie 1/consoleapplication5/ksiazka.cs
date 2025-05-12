using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
   public class Ksiazka
    {
        public int Id { get; set; }
        public string Tytul { get; set; }
        public int IloscStron { get; set; }
        public static List<string> AutorArray { get; set; }

        /// <summary>
        /// 0- Ksiazka zagubiono
        /// 1- Ksiazka aktywna
        /// 2- Ksiazka tylko do skorzystania w czytelni
        /// </summary>
        public enum StatusKsiaszki
        {
            ZAGUBIONO = 0,
            AKTYWNA = 1,
            CZYTRLNIK = 2,
            WYPOZYCONA = 3
        }
        public StatusKsiaszki Status { get; set; }

        public void Wypozycz()
        {
            Status = StatusKsiaszki.WYPOZYCONA;
        }
        public void Zwrot()
        {
            Status = StatusKsiaszki.AKTYWNA;
        }
    }
}
