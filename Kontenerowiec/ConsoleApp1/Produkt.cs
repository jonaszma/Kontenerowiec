namespace ConsoleApp1;

public class Produkt
{
    public RodzajProduktu Rodzaj { get; }
    public int Temperatura { get; }

    public Produkt(RodzajProduktu rodzaj, int temperatura)
    {
        Rodzaj = rodzaj;
        Temperatura = temperatura;
    }
}