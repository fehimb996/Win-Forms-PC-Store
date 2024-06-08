using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DrugiProjekat
{
    public class clsPrinter : clsUredjaj, iUredjaj
    {
        public string Tehnologija { get; set; }
        public bool UBoji { get; set; }

        public new string ProdatProizvod()
        {
            return "Printer, ProdatProizvod";
        }
    }

    public class clsInkJetPrinter : clsPrinter
    {
        public int BrojBoja { get; set; }

        public clsInkJetPrinter(string proizvodjac, string nazivUredjaja, decimal cena,
                             string tehnologija, bool uBoji, int brojBoja)
            : base()
        {
            this.Proizvodjac = proizvodjac;
            this.NazivUredjaja = nazivUredjaja;
            this.Cena = cena;
            this.Tehnologija = tehnologija;
            this.UBoji = uBoji;
            this.BrojBoja = brojBoja;
        }
    }

    public class clsLaserPrinter : clsPrinter
    {
        public bool NFCFunkcionalnost { get; set; }

        public clsLaserPrinter(string proizvodjac, string nazivUredjaja, decimal cena,
                            string tehnologija, bool uBoji, bool nfcFunkcionalnost)
            : base()
        {
            this.Proizvodjac = proizvodjac;
            this.NazivUredjaja = nazivUredjaja;
            this.Cena = cena;
            this.Tehnologija = tehnologija;
            this.UBoji = uBoji;
            this.NFCFunkcionalnost = nfcFunkcionalnost;
        }
    }
}
