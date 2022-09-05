using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_1_OOP
{
    class Opilane : Isik
    {
        public string koolinimi;
        public string klass;
        public string spetsialiseerumine;

        public Opilane(sugu inimeneSugu, string koolinimi, string klass, string spetsialiseerumine, string nimi, int synniAasta) : base(inimeneSugu, nimi, synniAasta)
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine;
        }

        public void Opilaned()
        {
            Console.WriteLine($"Koolinimi {koolinimi}. Sinu klass {klass} ja spetsialiseerumine {spetsialiseerumine}");
        }
    }
}
