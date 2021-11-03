using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berek2020
{
  class Berek
  {
    private string nev;

    public string Nev
    {
      get { return nev; }
      set { nev = value; }
    }
    private string neme;

    public string Neme
    {
      get { return neme; }
      set { neme = value; }
    }
    private string reszleg;

    public string Reszleg
    {
      get { return reszleg; }
      set { reszleg = value; }
    }
    private int belepes;

    public int Belepes
    {
      get { return belepes; }
      set { belepes = value; }
    }
    private int dolgozober;

    public int Dolgozober
    {
      get { return dolgozober; }
      set { dolgozober = value; }
    }

    public Berek(string nev, string neme, string reszleg, int belepes, int dolgozober)
    {
      this.nev = nev;
      this.neme = neme;
      this.reszleg = reszleg;
      this.belepes = belepes;
      this.dolgozober = dolgozober;
    }
  }
}
