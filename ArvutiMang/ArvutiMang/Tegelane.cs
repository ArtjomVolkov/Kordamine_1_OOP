using ArvutiMang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ArvutiMang
{
    internal class Tegelane : IUksus, IComparable<Tegelane> //Klass Tegelane realiseerib liidese Üksus.
    {
        string nimi;
        List<Ese> esed; //1. Klassis on privaatsed isendiväljad järgmise info jaoks: nimi (String) ja esemete nimekiri (List<Ese>).

        public Tegelane(string nimi)
        {
            esed = new List<Ese>();
            this.nimi = nimi;
        }

        public int CompareTo(Tegelane? other) //7. Klass Tegelane realiseerib liidese Comparable<Tegelane>, kusjuures compareTo meetod realiseeritakse nii, et võrdlemine toimub esemete arvu alusel.
        {
            if (other == null) return 1;
            return this.esed.Count - other.ItemCount();
        }

        public void Equip(Ese ese) { esed.Add(ese); } //Äsjaloodud tegelasel ei ole ühtegi eset. Eseme lisamiseks peab olema meetod lisaEse, mis jätab argumendiks antud eseme meelde.

        public int ItemCount() { return esed.Count; }

        public string Info() //Meetod info tagastab tegelase info tekstina, näidates tegelase nime, esemete arvu ja punktide arvu.
        {
            return $"Игрок {nimi}. Информация:\n" +
                $"---------------------------\n" +
                $"Количество вещей: {esed.Count}\n" +
                $"Количество пунктов: {PuntkideArv()}\n" +
                $"---------------------------\n";
        }

        public int PuntkideArv() //3. Meetod punktideArv tagastab punktide arvu.
        {
            int sum = 0;
            foreach (Ese ese in esed) { sum += ese.PuntkideArv(); }
            return sum;
        }

        public void väljastaEsemed() //6. Klassis peab olema ka meetod väljastaEsemed, kus väljastatakse ekraanile tegelase esemed nii, et iga ese on eraldi real.
        {
            foreach (Ese ese in esed)
            {
                Console.WriteLine(ese.Info() + " " + ese.PuntkideArv());
            }
        }
    }
}
