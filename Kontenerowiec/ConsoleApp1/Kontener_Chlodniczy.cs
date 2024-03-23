namespace ConsoleApp1;

public class Kontener_Chlodniczy :Kontener
{
    private List<Produkt> produkty;
    private List<double> waga_produktow;
    private double Temperatura;
    private RodzajProduktu Produkty;
    
    public Kontener_Chlodniczy(
        int Wysokosc, int wagawlasna, int glebokosc,
        double wagamax, RodzajProduktu rodzaj, double temperatura,string ko="C") 
        : base( Wysokosc, wagawlasna, glebokosc, wagamax,ko)
    {
        Produkty = rodzaj;
        produkty = new List<Produkt>();
        waga_produktow = new List<double>();
        Temperatura = temperatura;
    }

    public void zaladujladunek(Produkt produkt, double masa)
    {
        if (Produkty!=produkt.Rodzaj|| Temperatura<produkt.Temperatura)
        {
            Console.WriteLine("Inny rodzaj produktu albo za niska temeratura!");
        }
        else
        {
            produkty.Add(produkt);
            waga_produktow.Add(masa);
            base.zaladujladunek(masa);    
        }
        
    }

    public override void oproznijladunek()
    {
        produkty.Clear();
        waga_produktow.Clear();
        base.oproznijladunek();
    }

    public override string ToString()
    {
        string lista1 = "";
        foreach (var i in produkty)
        {
            lista1 += i.ToString()+ " ";
        }

        string waga = "";
        foreach (var VARIABLE in waga_produktow)
        {
            waga += VARIABLE.ToString()+ " ";
        }
        
        return base.ToString()+$" produkt: {Produkty}-produkty: {lista1}-waga produktow: {waga}-temperatura: {Temperatura}";
    }
}