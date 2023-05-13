using System;

public class MK : Postac
{
    private int mkwiek;

    public MK(string mkImie, int mkZywotnosc, int mkSila, int mkWiek) : base(mkImie, mkZywotnosc, mkSila)
    {
        mkwiek = mkWiek;
    }

    public MK() : this("Student", 100, mkRzutK6(2), 25)
    {
    }

    public int mkWiek
    {
        get { return mkwiek; }
        set { mkwiek = value; }
    }

    public override string mkTypPostaci()
    {
        return "MK";
    }
}