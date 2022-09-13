using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_1_OOP
{
    class Tootaja : Isik
    {
        public string asutus;
        public string amet;
        public string tootasu;
        public int pikkus;

        public Tootaja(Sugu inimeneSugu, string asutus, string amet, string tootasu, string nimi, int synniAasta, double maksuvaba, double palk,int pikkus) : base(inimeneSugu, nimi, synniAasta, maksuvaba, palk) 
        {
            this.asutus = asutus; 
            this.amet = amet;
            this.tootasu = tootasu;
            this.nimi = nimi;
            this.pikkus = pikkus;
            
            
        }

        public double arvutaSissetulek(double maksuvaba, double tulumaks, double palk)
        {
            double netopalk = ((palk - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }

        public int arvitaVanus()
        {
            int vanus = DateTime.Now.Year - synniAasta;
            return vanus;
        }

        public int Piikus()
        {
            int pikkus1 = pikkus;
            return pikkus1;
        }

        public void print_Info()
        {
            Console.WriteLine($"Tema asutus koht on {asutus}, tema amet on {amet} ja tema tootasu on {arvutaSissetulek(palk, maksuvaba, tulumaks)}, tema nimi on {nimi} {inimeneSugu} ja {arvitaVanus()}. Sinu pikkus {pikkus}");
        }
    }
}
