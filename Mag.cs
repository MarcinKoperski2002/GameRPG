using System;

public class Mag : Postac
{
    private int mkpunktymagii;
    public Mag(string mkImie, int mkZywotnosc, int mkSila, int mkPunktyMagii) : base(mkImie, mkZywotnosc, mkSila)
    {
        mkpunktymagii = mkPunktyMagii;
    }

    public Mag() : this("Xardas", 100, mkRzutK6(1), mkRzutK6(2))
    {
    }

    public int mkPunktyMagii
    {
        get { return mkpunktymagii; }
        set { mkpunktymagii = value; }
    }

    public override int mkMocAtaku()
    {
        return (mkPunktyMagii + mkSila) * mkZywotnosc;
    }

    public override string mkTypPostaci()
    {
        return "Mag";
    }
}