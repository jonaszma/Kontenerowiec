// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Kontener_Chlodniczy kontenerChlodniczy = new Kontener_Chlodniczy( 100, 10, 100, 100, RodzajProduktu.Mieso, 10);
Kontener_na_Plyny kontenerNaPlyny = new Kontener_na_Plyny(100, 10, 100, 100, true);
Kontener_Na_Gazy kontenerNaGazy = new Kontener_Na_Gazy(100, 10, 100, 100, 100);

kontenerNaPlyny.zaladujladunek(30);
Produkt produkt = new Produkt(RodzajProduktu.dania, 20, "Pizza");
Produkt produkt2 = new Produkt(RodzajProduktu.Mieso, 5,"Kurczak");
kontenerChlodniczy.zaladujladunek(produkt,20);
kontenerChlodniczy.zaladujladunek(produkt2,20);
kontenerNaGazy.zaladujladunek(70);
//kontenerNaGazy.zaladujladunek(700);
Console.WriteLine(kontenerChlodniczy);
Console.WriteLine(kontenerNaGazy);
kontenerNaGazy.oproznijladunek();
Console.WriteLine(kontenerNaGazy);
Console.WriteLine(kontenerNaPlyny);
Kontener_Chlodniczy kontenerChlodniczy2 = new Kontener_Chlodniczy( 100, 10, 100, 100, RodzajProduktu.Mieso, 10);
Console.WriteLine(kontenerChlodniczy2);

Kontenerowiec kontenerowiec=new Kontenerowiec(100,100,300);
Kontenerowiec kontenerowiec2=new Kontenerowiec(100,100,300);
List<Kontener> konteners = new List<Kontener>() { kontenerChlodniczy, kontenerNaGazy };
kontenerowiec.ZaladujKontener(kontenerChlodniczy);
kontenerowiec2.ZaladujKontenery(konteners);
Console.WriteLine(kontenerowiec);
Console.WriteLine(kontenerowiec2);
kontenerowiec.Przenies(0,kontenerowiec2);
kontenerowiec2.Zastap_kontener(0,kontenerNaPlyny);
Console.WriteLine(kontenerowiec);
Console.WriteLine(kontenerowiec2);
kontenerowiec2.UsuniecieKontenera(0);



