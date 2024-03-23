namespace ConsoleApp1;

public class Produkt
{
    public RodzajProduktu Rodzaj { get; }
    public int Temperatura { get; }
    private string Nazwa;

    public Produkt(RodzajProduktu rodzaj, int temperatura, string nazwa)
    {
        Rodzaj = rodzaj;
        Temperatura = temperatura;
        Nazwa = nazwa;
    }

    public override string ToString()
    {
        return $"rodzaj: {Rodzaj} - temperatura: {Temperatura} - Nazwa: {Nazwa}";
    }
}