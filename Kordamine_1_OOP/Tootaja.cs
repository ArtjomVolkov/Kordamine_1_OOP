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

        public Tootaja(sugu inimeneSugu,string asutus, string amet, string tootasu,string nimi,int synniAasta):base(inimeneSugu,nimi,synniAasta)
        {
            this.asutus = asutus;
            this.amet = amet;
            this.tootasu = tootasu;
        }

        public override double arvutaSissetulek(double maksuvaba,double tulumaks)
        {
            double clearPlak = ((tootasu - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return clearPlak;
        }
    }
}
