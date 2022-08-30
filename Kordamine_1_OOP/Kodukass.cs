using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_1_OOP
{
    class Kodukass : Koduloom
    {
        public string toug;//tõug - порода
        public Kodukass(string toug,string nimi, string varv, char sugu, double kaal, int vanus, bool elav) :base(nimi,varv,sugu,kaal,vanus,elav)
        {
            this.toug = toug;
        }
        public override void print_Info()
        {
            string sugu_text = "";
            if (sugu == 'I')
            {
                sugu_text = "Mees";
            }
            else if (sugu == 'E')
            {
                sugu_text = "Naine";
            }

            string elav_text = "";
            if (elav == true)
            {
                elav_text = "Elav";
            }
            else if (elav == false)
            {
                elav_text = "Surnud";
            }
            Console.WriteLine("{0} tõug,{1} {2} {3} ta on {4} ja tema kaal on {5} ja ta on {6} aastat vana.",toug, elav_text, varv, nimi, sugu_text, kaal, vanus);
        }
    }
}
