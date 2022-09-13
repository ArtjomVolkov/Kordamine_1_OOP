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
        public string koht;
        public int perepalk;
        public int lastearv;
        public double keskhind;
        public int toetus1;

        public Kutsekooliopilane(Sugu inimeneSugu, string oppeasutus, string eriala, string kursus,int toetus, string nimi, int synniAasta, double maksuvaba, double palk, int pikkus,int toetus1,string koht,int perepalk,int lastearv,double keskhind) : base(inimeneSugu, nimi, synniAasta, maksuvaba, palk)
        {
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.toetus = toetus;
            this.nimi = nimi;
            this.pikkus = pikkus;
            this.toetus1 = toetus1;


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
        public int Toetus1()
        {
            int kT = 0;
            int sT = 30;
            int pT = 60;
            int eT = 45;
            if (koht=="Tallinn")
            {
                int toetus1=kT += sT;
                return toetus1;
            }
            else if (perepalk <= 300)
            {
                int toetus1=eT += pT;
                return toetus1;
            }
            else if (keskhind >= 3.7)
            {
                int toetus1=kT += pT;
                return toetus1;
            }
            else
            {
                int toetus1= kT = 0;
                return toetus1;
            }
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
            Console.WriteLine($"Tema toetus on {Toetus1()} euro .Tema oppeasutus koht on {oppeasutus}, tema eriala on {eriala}, tema kurrus on {kursus}, tema toetus on {toetus} ja {Toetus()} ja tema tootasu on {arvutaSissetulek(palk, maksuvaba, tulumaks)}, tema nimi on {nimi} {inimeneSugu} ja {arvitaVanus()}. Sinu pikkus {pikkus}");
        }
    }
}
