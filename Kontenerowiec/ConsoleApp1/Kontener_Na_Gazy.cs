namespace ConsoleApp1;

public class Kontener_Na_Gazy: Kontener, IHazardNotifier
{
    public double Cisnienie { get; set; }

    public Kontener_Na_Gazy( int wysokosc, int wagaWlasna, int glebokosc, double max_masa,
        double cisnienie,String ko="G") : base(wysokosc,wagaWlasna, glebokosc,max_masa,ko)
    {
        Cisnienie = cisnienie;
    }

    public override void oproznijladunek()
    {
        masa = masa * 0.05;
    }

    public void ZgloszenieNiebezpieczenstwa(string numer)
    {
        Console.WriteLine($"Niebezpieczna sytuacja w kontenerza na plyny {numer_seryjny} : "+numer);
    }

    public override void zaladujladunek(double Masa)
    {
        if (masa>max_masa)
        {
            throw new OverfillException("przekroczone maksymalną mase");
        }
        base.zaladujladunek(Masa);
    }

    public override string ToString()
    {
        return base.ToString()+$"cisnienie: {Cisnienie} hPa";
    }
}