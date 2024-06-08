using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiProjekat
{
    public class clsMobilniUredjaj : clsUredjaj, iMobilniUredjaj
    {
        public string OperativniSistem { get; set; }
        public bool PodrzavaSIMKarticu {  get; set; }
        public string VrstaSIMKartice { get; set; }
        public int VelicinaRAMMemorije {  get; set; }
        public int VelicinaSkladisneMemorije { get; set; }

        public new string ProdatProizvod()
        {
            return "Mobilni uređaj, ProdatProizvod";
        }
    }

    public class clsTelefon : clsMobilniUredjaj
    {
        public string Model { get; set; }
        public int KapacitetBaterije { get; set; }
        public string TehnologijaMreze {  get; set; }
        public string WiFiStandard { get; set; }

        public clsTelefon(string proizvodjac, string nazivUredjaja, decimal cena,
                       string operativniSistem, bool podrzavaSIMKarticu, string vrstaSIMKartice, int velicinaRAMMemorije, int velicinaSkladisneMemorije, string model, int kapacitetBaterije, string tehnologijaMreze, string wiFiStandard)
            : base()
        {
            this.Proizvodjac = proizvodjac;
            this.NazivUredjaja = nazivUredjaja;
            this.Cena = cena;
            this.OperativniSistem = operativniSistem;
            this.PodrzavaSIMKarticu = podrzavaSIMKarticu;
            this.VrstaSIMKartice = vrstaSIMKartice;
            this.VelicinaRAMMemorije = velicinaRAMMemorije;
            this.VelicinaSkladisneMemorije = velicinaSkladisneMemorije;
            this.Model = model;
            this.KapacitetBaterije = kapacitetBaterije;
            this.TehnologijaMreze = tehnologijaMreze;
            this.WiFiStandard = wiFiStandard;
        }
    }

    public class clsTablet : clsMobilniUredjaj
    {
        public double VelicinaEkrana { get; set; }

        public clsTablet(string proizvodjac, string nazivUredjaja, decimal cena,
                      string operativniSistem, bool podrzavaSIMKarticu, string vrstaSIMKartice, int velicinaRAMMemorije, int velicinaSkladisneMemorije, double velicinaEkrana)
            : base()
        {
            this.Proizvodjac = proizvodjac;
            this.NazivUredjaja = nazivUredjaja;
            this.Cena = cena;
            this.OperativniSistem = operativniSistem;
            this.PodrzavaSIMKarticu = podrzavaSIMKarticu;
            this.VrstaSIMKartice = vrstaSIMKartice;
            this.VelicinaRAMMemorije = velicinaRAMMemorije;
            this.VelicinaSkladisneMemorije = velicinaSkladisneMemorije;
            this.VelicinaEkrana = velicinaEkrana;
        }
    }
}
