using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiProjekat
{
    public class clsKonzola : clsUredjaj, iUredjaj
    {
        public string TipMedija { get; set; }

        public new string ProdatProizvod()
        {
            return "Konzola, ProdatProizvod";
        }
    }

    public class clsGamingKonzola : clsKonzola
    {
        public int BrojIgrica { get; set; }

        public clsGamingKonzola(string proizvodjac, string nazivUredjaja, decimal cena, string tipMedija, int brojIgrica)
            : base()
        {
            this.Proizvodjac = proizvodjac;
            this.NazivUredjaja = nazivUredjaja;
            this.Cena = cena;
            this.TipMedija = tipMedija;
            this.BrojIgrica = brojIgrica;
        }
    }

    public class clsPrenosivaKonzola : clsKonzola
    {
        public bool PodrzavaBluetooth { get; set; }

        public clsPrenosivaKonzola(string proizvodjac, string nazivUredjaja, decimal cena, string tipMedija, bool podrzavaBluetooth)
            : base()
        {
            this.Proizvodjac = proizvodjac;
            this.NazivUredjaja = nazivUredjaja;
            this.Cena = cena;
            this.TipMedija = tipMedija;
            this.PodrzavaBluetooth = podrzavaBluetooth;
        }
    }
}
