using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_AS
{
    public class KnjigaClass
    {
        string ime, naziv, isbn, izdavac;
        int godina;

        public string Ime { get => ime; set => ime = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Izdavac { get => izdavac; set => izdavac = value; }
        public int Godina { get => godina; set => godina = value; }

        public KnjigaClass(string ime, string naziv, string isbn, string izdavac, int godina)
        {
            Ime = ime;
            Naziv = naziv;
            Isbn = isbn;
            Izdavac = izdavac;
            Godina = godina;
        }

        public override string ToString()
        {
            string ispis = null;

            ispis = this.Ime + "\t" + this.Naziv + "\t" +this.Izdavac + "\t" + this.Godina + "\t" + this.Isbn;

            return ispis;
        }
    }
}
