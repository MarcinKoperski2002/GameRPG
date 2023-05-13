using System;

public abstract class Postac
{
    private string mkimie;
    private int mkzywotnosc;
    private int mksila;

    public Postac(string mkImie, int mkZywotnosc, int mkSila)
    {
        mkimie = mkImie;
        mkzywotnosc = mkZywotnosc;
        mksila = mkSila;
    }

    public Postac() : this("Nieznany", 100, mkRzutK6(2))
    {
    }

    public string mkImie
    {
        get { return mkimie; }
        set { mkimie = value; }
    }

    public int mkZywotnosc
    {
        get { return mkzywotnosc; }
        set { mkzywotnosc = value; }
    }

    public int mkSila
    {
        get { return mksila; }
        set { mksila = value; }
    }

    public int mkZmianaWartosci(int mkzmiana)
    {
        mkzywotnosc += mkzmiana;
        if (mkzywotnosc < 0) mkzywotnosc = 0;
        else if (mkzywotnosc > 100) mkzywotnosc = 100;
        return mkzywotnosc;
    }

    public static int mkRzutK6(int mkrzut)
    {
        int mksuma = 0;
        int mkoczka = 6;
        Random mkLosowanie = new Random();
        for (int i = 0; i < mkrzut; i++)
        {
            mksuma += mkLosowanie.Next(1, mkoczka + 1);
        }

        return mksuma;
    }

    public virtual int mkMocAtaku()
    {
        return mkSila * mkZywotnosc;
    }

    public virtual string mkTypPostaci()
    {
        return "Nieznany";
    }

    public override string ToString()
    {
        return $"Imię: {mkimie} \nŻywotność: {mkzywotnosc}% \nSiła: {mkMocAtaku()}\n";
    }
}