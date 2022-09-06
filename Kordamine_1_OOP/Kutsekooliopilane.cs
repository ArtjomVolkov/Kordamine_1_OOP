using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_1_OOP
{
    class Kutsekooliopilane : Isik
    {
        public string oppeasutus;
        public string eriala;
        public string kursus;
        public int toetus;
        public int pikkus;

        public Kutsekooliopilane(Sugu inimeneSugu, string oppeasutus, string eriala, string kursus,int toetus, string nimi, int synniAasta, double maksuvaba, double palk, int pikkus) : base(inimeneSugu, nimi, synniAasta, maksuvaba, palk)
        {
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.toetus = toetus;
            this.nimi = nimi;
            this.pikkus = pikkus;


        }
        public double arvutaSissetulek(double maksuvaba, double tulumaks, double palk)
        {
            double netopalk = ((palk - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }
        public int arvutaVanus()
        {
            int vanus = DateTime.Now.Year - synniAasta;
            return vanus;
        }
        public int Piikus()
        {
            int pikkus1 = pikkus;
            return pikkus1;
        }
        public string Toetus()
        {
            if (toetus == 60)
            {
                return("sa õpid hästi.");
            }
            else if (toetus == 120)
            {
                return("sa õpid hästi.");
            }
            else if (toetus == 180)
            {
                return ("sa õpid hästi.");
            }
            else
            {
                return("sa õpid halvasti.");
            }
        }
        public void print_Info()
        {
            Console.WriteLine($"Tema oppeasutus koht on {oppeasutus}, tema eriala on {eriala}, tema kurrus on {kursus}, tema toetus on {toetus} ja {Toetus()} ja tema tootasu on {arvutaSissetulek(palk, maksuvaba, tulumaks)}, tema nimi on {nimi} {inimeneSugu} ja {arvitaVanus()}. Sinu pikkus {pikkus}");
        }
    }
}
