using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvutiMang
{
    internal class Tegelane : Entity
    {
        string nimi;

        public Tegelane(string nimi)
        {
            this.nimi = nimi;
        }
        List<Ese> EseInim = new List<Ese>();

        public void muuda_Nimi(string uusNimi) { nimi = uusNimi; }

       
    }
}
