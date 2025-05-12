using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApplication5.Ksiazka;

namespace ConsoleApplication5
{
    public class BibliotekaSerwis
    {
        private static List<Ksiazka> Ksiazki= new List<Ksiazka>()
        {
            new Ksiazka() { Id = 1,Tytul = "Rzemieślnik oprogramowania", IloscStron = 500, Status = Ksiazka.StatusKsiaszki.AKTYWNA},
            new Ksiazka() { Id = 2,Tytul = "Grafika w mediach", IloscStron = 670, Status = Ksiazka.StatusKsiaszki.AKTYWNA},
            new Ksiazka() { Id = 3,Tytul = "PHP for lamers", IloscStron = 120, Status = Ksiazka.StatusKsiaszki.WYPOZYCONA},
            new Ksiazka() { Id = 4,Tytul = "Wzorce projektowe", IloscStron = 450, Ksiazka.StatusKsiaszki.ZAGUBIONO},
        };

        private void WyslijInformacjeDoCzytelnika(string temat, string tresc, string emailDo, string emailFrom,
            FileStream zalacznik)
        {
            //logika wypozyczenia ksiazki
        }

        public bool WypozyczKsiazke(int idksiazka, Czytelnik czytelnik)
        {
            try
            {

                if (!Ksiazki.Any(x => x.Id == idksiazka))
                    return false;

                    var ksiazka = Ksiazki.First(x => x.Id == idksiazka);

                        //sprawdzamy czy czytelnik moze wypozyczyc ksiazke, max 2 ksiazki moze miec jedna osoba
                if (ksiazka.Status ==Ksiazka.StatusKsiaszki.AKTYWNA && czytelnik.CzyMoznaWypozyczyc())
                {
                    ksiazka.Wypozycz();
                    czytelnik.KsiazkiWyporzyczone.Add(ksiazka.Id);
                    var temat = "Wypozyczono ksiązke";
                    var tresc = "wypozyczyles ksiazke tytul" + ksiazka.Tytul;
                    WyslijInformacjeDoCzytelnika(temat, tresc, "bb@wp.pl", "cc@wp.pl", null);
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                var ksiazka = Ksiazki.First(x => x.Id == idksiazka);
                ksiazka.Zwrot();
                throw;
               
            }
           
        }
    }
}
