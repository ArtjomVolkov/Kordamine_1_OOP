using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_1_OOP
{
    abstract class Isik
    {
        public string nimi;
        public int synniAasta;
        public enum sugu { isane, emane };
        public sugu inimeneSugu;

        public Isik()
        {

        }

        public Isik(sugu inimeneSugu,string nimi = "---", int synniAasta=0)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.inimeneSugu = inimeneSugu;
        }
        public void printInfo()
        {
            Console.WriteLine($"Sinu nimi on {nimi},sinu sunniaasta {synniAasta} ja sinu sugu {inimeneSugu}.");
        }

        public int arvitaVanus()
        {
            int vanus = DateTime.Now.Year - synniAasta ;
            return vanus;
        }
        public void muuda_Nimi(string uusNimi)
        {
            nimi = uusNimi;
        }
        abstract void arvutaSissetulek()
        {
            double k;
        }

    }
}
