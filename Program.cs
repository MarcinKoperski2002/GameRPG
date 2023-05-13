using System;

class Program
{
    static void Main(string[] args)
    {
        Druzyna mkdruzyna = new Druzyna("Drużyna pierścienia");

        mkdruzyna.mkDodajPostac(new Mag("Marcin", 100, Postac.mkRzutK6(1), Postac.mkRzutK6(2)));
        mkdruzyna.mkDodajPostac(new Mag("Beniamin", 75, Postac.mkRzutK6(1), Postac.mkRzutK6(2)));
        mkdruzyna.mkDodajPostac(new Wojownik("Alan", 50, Postac.mkRzutK6(3)));
        mkdruzyna.mkDodajPostac(new Wojownik("Maciej", 25, Postac.mkRzutK6(3)));
        mkdruzyna.mkDodajPostac(new MK("Katarzyna", 5, Postac.mkRzutK6(2), 25));
        mkdruzyna.mkDodajPostac(new MK("Joanna", 1, Postac.mkRzutK6(2), 30));
        Console.WriteLine("Drużyna po utworzeniu:\n");
        Console.WriteLine(mkdruzyna.ToString());

        Console.WriteLine("Drużyna po zmianie żywotności z wojowników do 3%:\n");
        mkdruzyna[3].mkZmianaWartosci(-3);
        Console.WriteLine(mkdruzyna.ToString());

        Console.WriteLine("Kopia drużyny:\n");
        Druzyna? mkkopia = mkdruzyna.Clone() as Druzyna;
        Console.WriteLine(mkdruzyna.ToString());

        Console.WriteLine("\nNaciśnij dowolny przycisk, aby zakończyć działanie programu!");
        Console.ReadLine();
    }
}