using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiProjekat
{
    public class clsRacunar : clsUredjaj, iRacunar
    {
        private string _nazivProcesora;
        public string NazivProcesora
        {
            get { return _nazivProcesora; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("NazivProcesora ne sme da bude null ili prazno.");
                }
                if (!value.ToLower().Contains("ryzen") && !value.ToLower().Contains("core"))
                {
                    throw new ArgumentException("Pogrešna vrsta procesora.\nValidne vrste su Intel 'Core' i AMD 'Ryzen'.");
                }
                _nazivProcesora = value;
            }
        }
        private string _vrstaMemorijeRAM;
        public string VrstaMemorijeRAM
        {
            get { return _vrstaMemorijeRAM; }
            set
            {
                if(value != "DDR4" && value != "DDR5")
                {
                    throw new ArgumentException("Vrsta RAM Memorije mora da bude DDR4 ili DDR5.");
                }
                _vrstaMemorijeRAM = value;
            }
        }
        private int _velicinaMemorijeRAM;
        public int VelicinaMemorijeRAM
        {
            get => _velicinaMemorijeRAM;
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Veličina RAM memorije ne sme da bude 0 ili negativan broj.");
                }
                _velicinaMemorijeRAM = value;
            }
        }

        private string _tipSkladista;
        public string TipSkladista
        {
            get => _tipSkladista;
            set
            {
                if (value.ToLower().Contains("hdd") || value.ToLower().Contains("ssd"))
                {
                    _tipSkladista = value;
                }
                else
                {
                    throw new ArgumentException("TipSkladista mora biti HDD ili SSD.");
                }
            }
        }

        private int _kapacitetSkladista;
        public int KapacitetSkladista
        {
            get => _kapacitetSkladista;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Kapacitet skladista ne sme da bude 0 ili negativan broj.");
                }
                _kapacitetSkladista = value;
            }
        }

        private string _maticnaPloca;
        public string MaticnaPloca
        {
            get => _maticnaPloca;
            set
            {
                if(value != "Mini-ITX" && value != "Micro-ATX" && value != "ATX" && value != "E-ATX")
                {
                    throw new ArgumentException("Pogrešna vrsta Matične ploče.\nValidne vrste su Mini-ITX, Micro-ATX, ATX, i E-ATX");
                }
                _maticnaPloca = value;
            }
        }
        private string _grafickaKarta;
        public string GrafickaKarta
        {
            get => _grafickaKarta;
            set
            {
                if(!value.ToLower().Contains("geforce") && !value.ToLower().Contains("radeon") && !value.ToLower().Contains("arc"))
                {
                    throw new ArgumentException("Pogrešan model grafičke karte.\nValidni modeli su: GeForce, Radeon i Arc.");
                }
                _grafickaKarta = value;
            }
        }

        public decimal IzracunajPopust()
        {
            // Implementacija izračunavanja popusta za desktop
            return Cena * 0.2m; // Primer: 20% popusta
        }

        public new string ProdatProizvod()
        {
            return "Računar, ProdatProizvod";
        }
    }

    public class clsDesktop : clsRacunar
    {
        private string _vrstaKucista;
        public string VrstaKucista
        {
            get => _vrstaKucista;
            set
            {
                if (value != "Small Form Factor" && value != "Mini Tower" && value != "Mid Tower" && value != "Full Tower")
                {
                    throw new ArgumentException("Pogrešna vrsta kućišta.\nValidne vrste su: Small Form Factor, Mini Tower, Mid Tower i Full Tower.");
                }
                _vrstaKucista = value;
            }
        }

        public clsDesktop(string proizvodjac, string nazivUredjaja, decimal cena,
                              string nazivProcesora, string vrstaMemorijeRAM, int velicinaMemorijeRAM,
                              string maticnaPloca, string grafickaKarta, string vrstaKucista,
                              string tipSkladista, int kapacitetSkladista)
            : base()
        {
            this.Proizvodjac = proizvodjac;
            this.NazivUredjaja = nazivUredjaja;
            this.Cena = cena;

            this.NazivProcesora = nazivProcesora;
            this.VrstaMemorijeRAM = vrstaMemorijeRAM;
            this.VelicinaMemorijeRAM = velicinaMemorijeRAM;
            this.MaticnaPloca = maticnaPloca;
            this.GrafickaKarta = grafickaKarta;
            this.VrstaKucista = vrstaKucista;

            this.TipSkladista = tipSkladista;
            this.KapacitetSkladista = kapacitetSkladista;
        }
    }


    public class clsLaptop : clsRacunar
    {
        private double _tezina;
        public double Tezina
        {
            get => _tezina;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Veličina ne sme da bude 0 ili negativna.");
                }
                _tezina = value;
            }
        }

        private int _kapacitetBaterije;
        public int KapacitetBaterije
        {
            get => _kapacitetBaterije;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Kapacitet baterije ne sme da bude 0 ili negativan broj.");
                }
                _kapacitetBaterije = value;
            }
        }

        public string FormattedKapacitetBaterije
        {
            get => $"{_kapacitetBaterije} Wh";
        }

        private double _velicinaMonitora;
        public double VelicinaMonitora
        {
            get => _velicinaMonitora;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Veličina monitora ne sme da bude 0 ili negativna.");
                }
                _velicinaMonitora = value;
            }
        }

        public clsLaptop(string proizvodjac, string nazivUredjaja, decimal cena,
                             string nazivProcesora, string vrstaMemorijeRAM, int velicinaMemorijeRAM,
                             string maticnaPloca, string grafickaKarta,
                             double tezina, int kapacitetBaterije, double velicinaMonitora, string tipSkladista, int kapacitetSkladista)
                : base()
        {
            this.Proizvodjac = proizvodjac;
            this.NazivUredjaja = nazivUredjaja;
            this.Cena = cena;
            this.NazivProcesora = nazivProcesora;
            this.VrstaMemorijeRAM = vrstaMemorijeRAM;
            this.VelicinaMemorijeRAM = velicinaMemorijeRAM;
            this.MaticnaPloca = maticnaPloca;
            this.GrafickaKarta = grafickaKarta;
            this.Tezina = tezina;
            this.KapacitetBaterije = kapacitetBaterije;
            this.VelicinaMonitora = velicinaMonitora;

            this.TipSkladista = tipSkladista;
            this.KapacitetSkladista = kapacitetSkladista;
        }
    }
    public class clsRaspberryPi : clsRacunar
    {
        public int GPIOBrojevi { get; set; }

        public clsRaspberryPi(string proizvodjac, string nazivUredjaja, decimal cena,
                           string nazivProcesora, string vrstaMemorijeRAM, int velicinaMemorijeRAM, string maticnaPloca, string grafickaKarta, int gpioBrojevi)
            : base()
        {
            this.Proizvodjac = proizvodjac;
            this.NazivUredjaja = nazivUredjaja;
            this.Cena = cena;
            this.NazivProcesora = nazivProcesora;
            this.VrstaMemorijeRAM = vrstaMemorijeRAM;
            this.VelicinaMemorijeRAM = velicinaMemorijeRAM;
            this.MaticnaPloca = maticnaPloca;
            this.GrafickaKarta = grafickaKarta;
            this.GPIOBrojevi = gpioBrojevi;
        }
    }

    public class clsArduino : clsRacunar
    {
        public int BrojAnalogUlaza { get; set; }
        public int BrojDigitalnihUlaza { get; set; }

        public clsArduino(string proizvodjac, string nazivUredjaja, decimal cena,
                       string nazivProcesora, string vrstaMemorijeRAM, int velicinaMemorijeRAM, string maticnaPloca, string grafickaKarta, 
                       int brojAnalogUlaza, int brojDigitalnihUlaza)
            : base()
        {
            this.Proizvodjac = proizvodjac;
            this.NazivUredjaja = nazivUredjaja;
            this.Cena = cena;
            this.NazivProcesora = nazivProcesora;
            this.VrstaMemorijeRAM = vrstaMemorijeRAM;
            this.VelicinaMemorijeRAM = velicinaMemorijeRAM;
            this.MaticnaPloca = maticnaPloca;
            this.GrafickaKarta = grafickaKarta;
            this.BrojAnalogUlaza = brojAnalogUlaza;
            this.BrojDigitalnihUlaza = brojDigitalnihUlaza;
        }
    }

    public class clsNvidiaJetsonNano : clsRacunar
    {
        public int CUDAJezgara { get; set; }

        public clsNvidiaJetsonNano(string proizvodjac, string nazivUredjaja, decimal cena,
                                string nazivProcesora, string vrstaMemorijeRAM, int velicinaMemorijeRAM, string maticnaPloca, string grafickaKarta, int cudaJezgara)
            : base()
        {
            this.Proizvodjac = proizvodjac;
            this.NazivUredjaja = nazivUredjaja;
            this.Cena = cena;
            this.NazivProcesora = nazivProcesora;
            this.VrstaMemorijeRAM = vrstaMemorijeRAM;
            this.VelicinaMemorijeRAM = velicinaMemorijeRAM;
            this.MaticnaPloca = maticnaPloca;
            this.GrafickaKarta = grafickaKarta;
            this.CUDAJezgara = cudaJezgara;
        }
    }
}
