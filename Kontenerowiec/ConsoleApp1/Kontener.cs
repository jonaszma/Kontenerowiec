﻿namespace ConsoleApp1;

public class Kontener
{
    public double masa { get; set; }
    public int wysokosc{ get; set; }
    public int waga_własna{ get; set; }
    public int Glebokosc{ get; set; }
    public String numer_seryjny{ get; set; }
    public double max_masa{ get; }
    private static int nnumer=0;
    
    
    public Kontener( int Wysokosc, int wagawlasna, int glebokosc, double wagamax,string ko)
    {
        masa=0 ;
        wysokosc = Wysokosc;
        waga_własna = wagawlasna;
        Glebokosc = glebokosc;
        max_masa = wagamax;
        numer_seryjny = GenerujNumerSeryjny(ko);
    }

    private string GenerujNumerSeryjny(string ko)
    {
        string rodzajKontenera = this.GetType().Name.Substring(0, 3).ToUpper();
        int numer = nnumer++;
        
        return $"KON-{ko}-{numer}";
    }

    public virtual void oproznijladunek()
    {
        masa = 0;
    }

    public virtual void zaladujladunek(double Masa)
    {
        if (Masa>max_masa)
        {
            throw new OverfillException("za duza masa");
        }
        else
        {
         masa += Masa;   
        }
        
        
    }

    public override string ToString()
    {
        return $"{numer_seryjny}- masa: {masa} -max_masa: {max_masa}-wysokosc: {wysokosc}-glebokosc: {Glebokosc}-waga wlasna: {waga_własna}";
    }
}
















