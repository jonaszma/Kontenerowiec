namespace ConsoleApp1;

public class Kontener_na_Plyny : Kontener, IHazardNotifier
{
    
    public bool ladunek_niebezpieczny { get; }

    public Kontener_na_Plyny( int wysokosc, int wagaWlasna, int glebokosc, double max_masa,
         bool lad_niebezpieczny,string ko="L") : base(wysokosc,wagaWlasna, glebokosc,max_masa,ko)
    {
       
        ladunek_niebezpieczny = lad_niebezpieczny;
    }

    public override void zaladujladunek(double Masa)
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

    public override string ToString()
    {
        return base.ToString()+$"przewozi ladunek niebezpieczny: {ladunek_niebezpieczny}";
    }
}






















