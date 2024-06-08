using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiProjekat
{
    public interface iUredjaj
    {
        string NazivUredjaja { get; set; }
        string Proizvodjac { get; set; }
        decimal Cena { get; set; }
        string ProdatProizvod();
    }

    public interface iRacunar : iUredjaj
    {
        string NazivProcesora { get; set; }
        string VrstaMemorijeRAM { get; set; }
        int VelicinaMemorijeRAM { get; set; }
        string MaticnaPloca {  get; set; }
        string GrafickaKarta { get; set; }
    }

    public interface iMobilniUredjaj : iUredjaj
    {
        string OperativniSistem { get; set; }
        bool PodrzavaSIMKarticu { get; set; }
        string VrstaSIMKartice { get; set; }
        int VelicinaRAMMemorije { get; set; }
        int VelicinaSkladisneMemorije { get; set; }

    }
}
