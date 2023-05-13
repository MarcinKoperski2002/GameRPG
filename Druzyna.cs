using System;

public class Druzyna : ICloneable
{
    private string mknazwadruzyny;
    private List<Postac> mkpostacie;

    public Druzyna(string mkNazwaDruzyny)
    {
        mknazwadruzyny = mkNazwaDruzyny;
        mkpostacie = new List<Postac>();
    }

    public object Clone()
    {
        Druzyna mkkopia = new Druzyna(mknazwadruzyny);

        foreach (Postac mkpostac in mkpostacie)
            if (mkpostac is Mag)
            {
                Mag mkmag = (Mag)mkpostac;
                mkkopia.mkDodajPostac(new Mag(mkmag.mkImie, mkmag.mkZywotnosc, mkmag.mkSila, mkmag.mkPunktyMagii));
            }
            else if (mkpostac is Wojownik)
            {
                Wojownik mkwojownik = (Wojownik)mkpostac;
                mkkopia.mkDodajPostac(new Wojownik(mkwojownik.mkImie, mkwojownik.mkZywotnosc, mkwojownik.mkSila));
            }
            else if (mkpostac is MK)
            {
                MK mkmk = (MK)mkpostac;
                mkkopia.mkDodajPostac(new MK(mkmk.mkImie, mkmk.mkZywotnosc, mkmk.mkSila, mkmk.mkWiek));
            }

        return mkkopia;
    }

    public void mkDodajPostac(Postac mkPostac)
    {
        mkpostacie.Add(mkPostac);
    }

    public Postac this[int mkindeks]
    {
        get { return mkpostacie[mkindeks]; }
        set { mkpostacie[mkindeks] = value; }
    }

    public int mkSumarycznaWartosc()
    {
        int mksumawartosci = 0;

        foreach (Postac mkpostac in mkpostacie)
            mksumawartosci += mkpostac.mkMocAtaku();

        return mksumawartosci;
    }

    public override string ToString()
    {
        string mkinfo = $"\nNazwa drużyny: {mknazwadruzyny} \n";
        mkinfo += $"Sumaryczna moc ataku: {mkSumarycznaWartosc()} \n";
        mkinfo += "Lista postaci: \n\n";

        foreach (Postac mkpostac in mkpostacie)
        {
            mkinfo += $"{mkpostac.mkTypPostaci()}: \n{mkpostac.ToString()}\n";
        }

        return mkinfo;
    }
}