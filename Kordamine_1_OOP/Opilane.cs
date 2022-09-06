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
        private int pikkus;
        string kool;

        public Opilane(Sugu inimeneSugu, string koolinimi, string klass, string spetsialiseerumine, string nimi, int synniAasta, int pikkus) : base(inimeneSugu, nimi, synniAasta)
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine;
            this.nimi = nimi;
            this.pikkus = pikkus;


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

        public string Koolinimi()
        {
            Console.WriteLine("Kas sa õpid TTHK või Gümnaasiumis?");
            kool = Console.ReadLine();
            if (kool == "TTHK")
            {
                return kool;
            }
            else
            {
                return kool;
            }
        }

        public void print_Info()
        {
            Console.WriteLine($"Tema koolinimi on {Koolinimi()}, klass on {klass} ja {spetsialiseerumine}. Tema nimi on {nimi} {inimeneSugu} ja {arvitaVanus()} aastat vana. Sinu pikkus {pikkus}");
        }
    }
}
