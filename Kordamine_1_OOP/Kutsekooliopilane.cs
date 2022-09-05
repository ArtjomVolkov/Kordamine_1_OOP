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
        public string toetus;

        public Opilane(sugu inimeneSugu, string oppeasutus, string eriala, string kursus, string toetus, string nimi, int synniAasta) : base(inimeneSugu, nimi, synniAasta)
        {
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.toetus = toetus;
        }
    }
}
