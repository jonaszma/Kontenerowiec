namespace ConsoleApp1;

public class Kontenerowiec
{
    private List<Kontener> _konteners;
    private double _Predkosc;
    private int _ilosc_kontenerów;
    private double _max_waga;

    public Kontenerowiec( double predkosc, int iloscKontenerów, double maxWaga)
    {
        _konteners = new List<Kontener>();
        _Predkosc = predkosc;
        _ilosc_kontenerów = iloscKontenerów;
        _max_waga = maxWaga;
    }

    public void ZaladujKontener(Kontener kontener)
    {
        double waga = 0;
        foreach (var VARIABLE in _konteners)
        {
            waga += VARIABLE.waga_własna + VARIABLE.masa;
        }

        waga += kontener.waga_własna + kontener.masa;
        if (waga<_max_waga)
        {
          _konteners.Add(kontener);  
        }
        else
        {
            Console.WriteLine("przekroczono dozwolona mase");
        }
        
    }

    public override string ToString()
    {
        Console.WriteLine($"predkosc: {_Predkosc}-ilosc kontenerow: {_ilosc_kontenerów}- max waga: {_max_waga} ton");
        Console.WriteLine("Kontenery:");
        for (int i = 0; i <_konteners.Count; i++)
        {
            Console.WriteLine(_konteners[i]);
        }
        return "";
    }

    public void ZaladujKontenery(List<Kontener> konteners)
    {
        _konteners.AddRange(konteners);
    }

    public void UsuniecieKontenera(int num_kon)
    {
        _konteners.RemoveAt(num_kon);
    }

    public void Zastap_kontener(int num, Kontener kontener)
    {
        _konteners[num] = kontener;
    }

    public void Przenies(int num, Kontenerowiec kontenerowiec)
    {
        Kontener kontener = _konteners[num];
        _konteners.RemoveAt(num);
        kontenerowiec.ZaladujKontener(kontener);
    }
    
    
}