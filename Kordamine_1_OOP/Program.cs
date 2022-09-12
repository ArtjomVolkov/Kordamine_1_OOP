/*using Kordamine_1_OOP;
Koduloom koer = new Koduloom("Murka", "Sinine", 'E', 10.7, 7, true);
koer.print_Info();
Koduloom koerKloon = new Koduloom(koer);
koerKloon.muuda_Nimi("Sergei");
koerKloon.print_Info();
Kodukass kass = new Kodukass("st",Koduloom.sugu 30,"Oleg","Punane",40.5,20,false);
kass.print_Info();*/


using Kordamine_1_OOP;
using System.Numerics;

Tootaja toot = new Tootaja(Isik.Sugu.emane,"TTHK","Holo","Joas","Artjom",2004,558,700,180);
toot.print_Info();
toot.arvitaVanus();
toot.Piikus();
Console.WriteLine("\n\n");

Kutsekooliopilane opi = new Kutsekooliopilane(Isik.Sugu.isane,"TTHk","TRA","3",500,"Jelena",2004,500,700,180,800,"Tallinn",200,1,4.6);
opi.print_Info();
opi.arvitaVanus();
opi.Piikus();
opi.Toetus();
opi.Toetus1();
Console.WriteLine("\n\n");

Opilane opin = new Opilane(Isik.Sugu.isane, "TTHK", "TARpv21", "Tarkvaraarendaja", "Mark", 2004, 175);
opin.print_Info();
opin.arvitaVanus();
opin.Piikus();
Console.WriteLine("\n\n");

List<Isik> Inimesed = new List<Isik>();
Inimesed.Add(toot);
Inimesed.Add(opi);
Inimesed.Add(opin);
StreamWriter to_file = new StreamWriter(@"C:\Users\ASUS\source\repos\Kordamine_1_OOP\Kordamine_1_OOP\People.txt", false);
foreach (Isik x in Inimesed)
{
    to_file.WriteLine(x.nimi + "," + x.arvitaVanus() + "," + x.inimeneSugu + ";");
}
to_file.Close();
StreamReader from_file = new StreamReader(@"C:\Users\ASUS\source\repos\Kordamine_1_OOP\Kordamine_1_OOP\People.txt");
string text = from_file.ReadToEnd();
Console.WriteLine(text);
from_file.Close();

string path = "C:\\Users\\ASUS\\source\\repos\\Kordamine_1_OOP\\Kordamine_1_OOP\\Peoples.txt";
using (StreamReader reader = new StreamReader(path))
{
    string texts = await reader.ReadToEndAsync();
    Console.WriteLine(texts);
}

StreamReader sr = new StreamReader("C:\\Users\\ASUS\\source\\repos\\Kordamine_1_OOP\\Kordamine_1_OOP\\Peoples.txt");
List<string> lines = new List<string>();
int n = sr.ReadToEnd().Split(new char[] {'\n'}).Length;
Console.WriteLine("---------" + n + "---------");