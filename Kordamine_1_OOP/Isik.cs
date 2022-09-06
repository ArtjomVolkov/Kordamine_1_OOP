using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_1_OOP
{
    public class Isik
    {
        public string nimi;
        public int synniAasta;
        public enum Sugu { isane, emane };
        public Sugu inimeneSugu;
        public int pikkus1;
        public double maksuvaba;
        public double palk;
        public double tulumaks;

        public Isik()
        { }

        public Isik(string nimi, int synniAasta, Sugu inimeneSugu, int pikkus1)
        {
            this.nimi = nimi;
            this.pikkus1 = pikkus1;
            this.synniAasta = synniAasta;
            this.inimeneSugu = inimeneSugu;
        }

        public Isik(Sugu inimeneSugu, string nimi, int synniAasta, double maksuvaba, double palk)
        {
            this.inimeneSugu = inimeneSugu;
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.maksuvaba = maksuvaba;
            this.palk = palk;
        }

        public Isik(Sugu inimeneSugu, string nimi, int synniAasta)
        {
            this.inimeneSugu = inimeneSugu;
            this.nimi = nimi;
            this.synniAasta = synniAasta;
        }

        public void print_Info()
        {
            Console.WriteLine($"Sinu nimi on {nimi}. Sa oled {synniAasta} aastat vana. Sinu sugu {inimeneSugu}. Pikkus - {pikkus1}");
        }
        public void muuda_Nimi(string uusNimi) { nimi = uusNimi; }

        public int arvitaVanus()
        {
            int vanus = DateTime.Now.Year - synniAasta ;
            return vanus;
        }
        public int Piikus()
        {
            int pikkus = pikkus1;
            return pikkus;
        }
    }
}
