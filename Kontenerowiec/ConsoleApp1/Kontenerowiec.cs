namespace ConsoleApp1;

public class Kontenerowiec
{
    private List<Kontener> _konteners;
    private double _Predkosc;
    private int _ilosc_kontenerów;
    private double _max_waga;

    public Kontenerowiec(List<Kontener> konteners, double predkosc, int iloscKontenerów, double maxWaga)
    {
        _konteners = konteners;
        _Predkosc = predkosc;
        _ilosc_kontenerów = iloscKontenerów;
        _max_waga = maxWaga;
    }

    public void ZaladujKontener(Kontener kontener)
    {
        _konteners.Add(kontener);
    }

    public override string ToString()
    {
        Console.WriteLine($"predkosc: {_Predkosc}-ilosc kontenerow: {_ilosc_kontenerów}- max waga: {_max_waga}");
        Console.WriteLine("Kontenery:");
        for (int i = 0; i <_konteners.Capacity; i++)
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