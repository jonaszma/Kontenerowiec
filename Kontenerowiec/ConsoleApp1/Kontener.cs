namespace ConsoleApp1;

public class Kontener
{
    public int masa { get; set; }
    public int wysokosc{ get; set; }
    public int waga_własna{ get; set; }
    public int Glebokosc{ get; set; }
    public String numer_seryjny{ get; set; }
    public int max_masa{ get; }
    private int nnumer=0;
    
    public Kontener(int masaladunku, int Wysokosc, int wagawlasna, int glebokosc, int wagamax)
    {
        masa=masaladunku ;
        wysokosc = Wysokosc;
        waga_własna = wagawlasna;
        Glebokosc = glebokosc;
        max_masa = wagamax;
        numer_seryjny = GenerujNumerSeryjny();
    }

    private string GenerujNumerSeryjny()
    {
        string rodzajKontenera = this.GetType().Name.Substring(0, 3).ToUpper();
        int numer = nnumer++;
        return $"{rodzajKontenera}-C-{numer}";
    }

    public void oproznijladunek()
    {
        masa = 0;
    }

    public virtual void zaladujladunek(int Masa)
    {
        if (Masa>max_masa)
        {
            throw new OverfillException("za duza masa");
        }
        else
        {
         masa = Masa;   
        }
        
        
    }
    

    
    
    
    
    
    
}
















