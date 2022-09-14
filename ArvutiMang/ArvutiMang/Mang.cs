using ArvutiMang;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvutiMang
{
    internal class Mang
    {
        private Tegelane[] tegelased; //Klassis Mäng peab olema privaatne isendiväli fikseeritud pikkusega tegelaste nimekirja (Tegelane[]) jaoks.Klassis peab olema ühe parameetriga konstruktor, mille abil saab määrata tegelastenimekirja.

        public Mang(Tegelane[] tegelased)
        {
            this.tegelased = tegelased;
        }

        public List<Tegelane> SuurimaEsemeteArvuga() //Klassis on Tegelane-tüüpi parameetriteta meetod suurimaEsemeteArvuga, mis tagastabsuurima esemete arvuga tegelase.Meetodis tegelased sorteeritakse vastavalt meetodis compareTo kirjeldatud järjekorrale ja sorteeritud massiivist võetakse suurima esemete arvuga tegelast.
        {
            List<Tegelane> winners = new List<Tegelane>();
            Tegelane comparable = tegelased[0];
            foreach (Tegelane plr in tegelased)
            {
                int num = comparable.CompareTo(plr);
                if (num < 0)
                {
                    comparable = plr;
                    winners.Clear();
                }
                if (num == 0) winners.Add(plr);
            }
            winners.Add(comparable);
            return winners;
        }
        public Tegelane SuurimaPunktideArvuga() // Klassis on Tegelane-tüüpi parameetriteta meetod suurimaPunktideArvuga, mis tagastab suurima punktide arvuga tegelase.
        {
            int highest = 0;
            Tegelane winner = tegelased[0];
            foreach (Tegelane plr in tegelased)
            {
                int arv = plr.PuntkideArv();
                if (arv > highest) { 
                    highest = arv; 
                    winner = plr; 
                }
            }
            return winner;
        }

    }
}
