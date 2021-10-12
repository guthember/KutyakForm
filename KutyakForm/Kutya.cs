using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakForm
{
  class Kutya
  {
    private int id;

    public int Id
    {
      get { return id; }
    }

    int fajta_id;
    int nev_id;

    private int eletkor;

    public int Eletkor
    {
      get { return eletkor; }
    }


    private DateTime ellenorzes ;

    public DateTime Ellenorzes
    {
      get { return ellenorzes ; }
    }

    public string Nev { get; set; }

    public string Fajta { get; set; }

    public Kutya(int id, int fajta_id, int nev_id, int eletkor, DateTime ellenorzes, List<Fajta> fajtak, List<Nev> nevek)
    {
      this.id = id;
      this.fajta_id = fajta_id;
      this.nev_id = nev_id;
      this.eletkor = eletkor;
      this.ellenorzes = ellenorzes;
      Nev = SelectNev(nev_id, nevek);
      Fajta = SelectFajta(fajta_id, fajtak);
    }

    private string SelectFajta(int id, List<Fajta> fajtak)
    {
      int i = 0;
      while (fajtak[i].Id != id)
      {
        i++;
      }

      return fajtak[i].Fajtanev;
    }

    private string SelectNev(int id, List<Nev> nevek)
    {
      int i = 0;
      while (nevek[i].Id != id)
      {
        i++;
      }

      return nevek[i].Kutyanev;
    }
  }
}
