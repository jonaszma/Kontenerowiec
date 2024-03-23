namespace ConsoleApp1;

public class Kontener_Na_Gazy: Kontener, IHazardNotifier
{
    public double Cisnienie { get; set; }

    public Kontener_Na_Gazy(int masaLadunku, int wysokosc, int wagaWlasna, int glebokosc, int max_masa,
        double cisnienie) : base(masaLadunku,wysokosc,wagaWlasna, glebokosc,max_masa)
    {
        Cisnienie = cisnienie;
    }

    public override void oproznijladunek()
    {
        masa = masa * 0.95;
    }

    public void ZgloszenieNiebezpieczenstwa(string numer)
    {
        throw new NotImplementedException();
    }
}