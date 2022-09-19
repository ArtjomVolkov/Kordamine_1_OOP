using ArvutiMang;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ArvutiMang
{
    internal static class Peaklass //Peaklass peab olema nimega Peaklass.
    {
        public static Random rnd = new Random(); //Random
        public static List<Ese> LoeEsemed() //Rakendatakse vastavat staatilist meetodit, et lugeda failist esemed.txt esemete andmed.
        {
            List<Ese> list = new List<Ese>();
            StreamReader sr = new StreamReader(@"C:\Users\ASUS\source\repos\Kordamine_1_OOP\ArvutiMang\ArvutiMang\items.txt");
            while (!sr.EndOfStream)
            {
                string[] info = sr.ReadLine().Split(";");
                Ese ese = new Ese(stringToInt(info[1]), info[0]);
                list.Add(ese);
            }
            return list;
        }

        static int stringToInt(string s)
        {
            int y = 0;
            int total = 0;
            for (int i = 0; i < s.Length; i++)
                y = y * 10 + (s[i] - '0');
            total += y;
            return total;
        }

        public static void Shuffle<T>(this IList<T> list) //Iga tegelase jaoks genereeritakse juhuslik arv n vahemikust [2,10], mis näitab selle tegelase esemete arvu.Iga tegelase jaoks valitakse juhuslikult n eset.Selleks tuleb kasutadaGollections.shuffle meetodit.Antud meetod võtab argumendiks listi ning järjestab sellesuvalises järjekorras. Esemete list järjestada iga tegelase jaoks uuesti ümber ning lisada tegelaseleesimest n eset.
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        static string getNime() 
        {
            string[] nimed = { "Biba", "Boba", "Denis", "Artjom", "Aleksandr", "Vlad", "Danil", "Timofei", "German", "Miha", "Edgard" }; //Luuakse vähemalt 5 tegelast (nimed mõelge ise välja)
            return nimed[rnd.Next(nimed.Length)];
        }

        static Tegelane[] populatemagijat(int plrCount)
        {
            if (plrCount < 4) throw new Exception();
            Tegelane[] plrs = new Tegelane[plrCount];
            for (int i = 0; i < plrCount; i++)
            {
                Tegelane plr = new Tegelane(getNime());
                plrs[i] = plr;
            }

            return annab_ese(plrs);
        }

        static Tegelane[] annab_ese(Tegelane[] plrs) 
        {
            List<Ese> eeseList = LoeEsemed();
            if (eeseList.Count <= 0) throw new ArgumentOutOfRangeException();
            foreach (Tegelane plr in plrs)
            {
                Shuffle(eeseList);
                int summa = rnd.Next(2, 10); //Iga tegelase jaoks genereeritakse juhuslik arv n vahemikust [2,10]
                for (int i = 0; i < summa; i++)
                {
                    plr.Equip(eeseList[i]);
                }
            }
            return plrs;
        }

        static public void Mang1(int plrCount) //Tegelaste info ja esemed väljastatakse ekraanile (kasutades vastavaid meetodeid).
        {
            Tegelane[] plrs = populatemagijat(plrCount);
            Mang mang = new Mang(plrs);
            foreach (Tegelane voitja1 in mang.SuurimaEsemeteArvuga())
            {
                Console.WriteLine(voitja1.Info());//Leitakse ja väljastatakse ekraanile suurima esemete arvuga tegelase info (kasutades vastavaid meetodeid).
            }
            Tegelane voita = mang.SuurimaPunktideArvuga();
            Console.WriteLine(voita.Info());
            Console.WriteLine("Игрок имел следующие предметы:");
            Console.WriteLine("-------------------------------");
            voita.väljastaEsemed();
            Console.WriteLine("-------------------------------");

        }

        public static void Mang() //Algab mäng
        {
            Console.WriteLine("Хотите сыграть в игру? Y/N");
            string jaei = Console.ReadLine();
            if (jaei == "Y")
            {
                Console.WriteLine("\n");
                Peaklass.Mang1(8);
                Console.WriteLine("Хотите еще сыграть? Y/N");
                string jaei1 = Console.ReadLine();
                while (jaei1 == "Y")
                {
                    Console.WriteLine("\n");
                    Peaklass.Mang1(8);
                    Console.WriteLine("Ещё раз? Y/N");
                    string jaei2 = Console.ReadLine();
                    if (jaei2 == "Y")
                    {

                    }
                    else
                    {
                        Console.WriteLine("Goodbye! My friend");
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Goodbye! My friend");
            }
        }
    }
}
