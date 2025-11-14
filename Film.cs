using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Film
{
    public string Cim { get; set; }
    public string Mufaj { get; set; }
    public string Ev { get; set; }
    public int Hossz { get; set; }
    public int Ertekeles { get; set; }

    public Film(string sor)
    {
        var adatok = sor.Split(';');
        Cim = adatok[0];
        Mufaj = adatok[1];
        Ev = adatok[2];
        Hossz = int.Parse(adatok[3]);
        Ertekeles = int.Parse(adatok[4]);
    }
}
