using ArvutiMang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvutiMang
{
    internal class Ese : IUksus //2. Klass Ese realiseerib liidese Üksus.
    {
        //1. Liides Üksus sisaldab
        int puntkideArv; //2.1. Klassis on privaatsed isendiväljad järgmise info jaoks: nimetus (String) ja punktide arv (int).
        string nimetus;

        public Ese(int puntkideArv, string nimetus)
        {
            this.puntkideArv = puntkideArv;
            this.nimetus = nimetus;
        }

        public int PuntkideArv() { return puntkideArv; } //1.1 int-tüüpi parameetriteta meetodit punktideArv;
        public string Info() { return nimetus; } //1.2 String-tüüpi parameetriteta meetodit info.
    }
}
