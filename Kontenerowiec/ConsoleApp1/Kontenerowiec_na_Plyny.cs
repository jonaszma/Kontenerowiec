namespace ConsoleApp1;

public class Kontenerowiec_na_Plyny : Kontener, IHazardNotifier
{
    public int Cisnienie { get; }
    public bool ladunek_niebezpieczny { get; }

    public Kontenerowiec_na_Plyny(int masaLadunku, int wysokosc, int wagaWlasna, int glebokosc, int max_masa,
        int cisnienie, bool lad_niebezpieczny) : base(masaLadunku,wysokosc,wagaWlasna, glebokosc,max_masa)
    {
        Cisnienie = cisnienie;
        ladunek_niebezpieczny = lad_niebezpieczny;
    }

    public override void zaladujladunek(int Masa)
    {
        if (ladunek_niebezpieczny)
        {
            if (masa<(max_masa*0.5))
            { 
                base.zaladujladunek(Masa);   
            }
            else
            {
                ZgloszenieNiebezpieczenstwa("za duza masa");
            }
        }
        else
        {
            if (masa<(max_masa*0.9))
            { 
                base.zaladujladunek(Masa);   
            }else
            {
                ZgloszenieNiebezpieczenstwa("za duza masa");
            }
        }
        
        
    }

    public void ZgloszenieNiebezpieczenstwa(string numer)
    {
        Console.WriteLine($"Niebezpieczna sytuacja w kontenerza na plyny {numer_seryjny} : "+numer);
    }
}






















