using System;

public class Wojownik : Postac
{
    public Wojownik(string mkImie, int mkZywotnosc, int mkSila) : base(mkImie, mkZywotnosc, mkSila)
    {
    }

    public Wojownik() : this("Geralt", 100, mkRzutK6(3))
    {
    }

    public override int mkMocAtaku()
    {
        if (mkZywotnosc < 5) return mkSila;
        else return mkSila * mkZywotnosc;
    }

    public override string mkTypPostaci()
    {
        return "Wojownik";
    }
}