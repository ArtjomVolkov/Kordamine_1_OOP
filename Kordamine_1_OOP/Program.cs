/*using Kordamine_1_OOP;
Koduloom koer = new Koduloom("Murka", "Sinine", 'E', 10.7, 7, true);
koer.print_Info();
Koduloom koerKloon = new Koduloom(koer);
koerKloon.muuda_Nimi("Sergei");
koerKloon.print_Info();
Kodukass kass = new Kodukass("st",Koduloom.sugu 30,"Oleg","Punane",40.5,20,false);
kass.print_Info();*/


using Kordamine_1_OOP;

/*Isik inimene = new Isik("Artjom", 2005, Isik.Sugu.isane, 174);
inimene.print_Info();
inimene.arvitaVanus();
inimene.Piikus();*/
/*Tootaja toot = new Tootaja(Isik.Sugu.emane,"TTHK","Holo","Joas","Artjom",2004,558,700,180);
toot.print_Info();
toot.arvitaVanus();
toot.Piikus();*/
Kutsekooliopilane opi = new Kutsekooliopilane(Isik.Sugu.emane, "Iki", "TAR", "1", 60, "Artjom", 2004, 500, 800, 170);
opi.print_Info();
opi.arvitaVanus();
opi.Piikus();
opi.Toetus();
