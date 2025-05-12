using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
   public class Czytelnik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Id { get; set; }
        public  List<int> KsiazkiWyporzyczone { get; set; }
        
        public const int MAX_LICZBA_KSIAZEK=2;
        public bool CzyMoznaWypozyczyc()
        {
            return KsiazkiWyporzyczone.Count < MAX_LICZBA_KSIAZEK;
        }
   }
}
