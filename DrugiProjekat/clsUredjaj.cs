using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugiProjekat
{
    public abstract class clsUredjaj : iUredjaj
    {
        private string _proizvodjac;
        public string Proizvodjac
        {
            get { return _proizvodjac; }
            set
            {
                if (value.Length < 2)
                {
                    throw new Exception("Naziv proizvođača mora da ima minimum 2 karaktera.");
                }
                _proizvodjac = value;
            }
        }

        private string _nazivUredjaja;
        public string NazivUredjaja
        {
            get { return _nazivUredjaja; }
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("Naziv uređaja mora da ima minimum 3 karaktera.");
                }
                _nazivUredjaja = value;
            }
        }

        private decimal _cena;
        public decimal Cena
        {
            get { return _cena; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Cena ne sme da bude negativna.");
                }
                _cena = value;
            }
        }

        public virtual string Prodaja()
        {
            return $"{GetType().Name} - Metoda Prodaja() je pozvana.";
        }

        public virtual string Dostava()
        {
            return $"{GetType().Name} - Metoda Dostava() je pozvana";
        }

        public string ProdatProizvod()
        {
            throw new NotImplementedException();
        }
    }
}
