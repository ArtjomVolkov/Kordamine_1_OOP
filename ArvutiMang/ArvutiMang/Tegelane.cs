﻿using ArvutiMang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvutiMang
{
    internal class Tegelane : Entity, IComparable<Tegelane>
    {
        string nimi;
        List<Ese> items;

        public Tegelane(string nimi)
        {
            items = new List<Ese>();
            this.nimi = nimi;
        }

        public int CompareTo(Tegelane? other)
        {
            if (other == null) return 1;
            return this.items.Count - other.ItemCount();
        }

        public void Equip(Ese item) { items.Add(item); }

        public int ItemCount() { return items.Count; }

        public string Info()
        {
            return $"Игрок {this.nimi}. Информация:\n" +
                $"---------------------------\n" +
                $"Количество вещей: {items.Count}\n" +
                $"Количество пунктов: {PuntkideArv()}\n" +
                $"---------------------------\n";
        }

        public int PuntkideArv()
        {
            int sum = 0;
            foreach (Ese item in items) { sum += item.PuntkideArv(); }
            return sum;
        }

        public void väljastaEsemed()
        {
            foreach (Ese item in items)
            {
                Console.WriteLine(item.Info() + " " + item.PuntkideArv());
            }
        }
    }
}
