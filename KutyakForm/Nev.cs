using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakForm
{
  class Nev
  {
    private int id;

    public int Id
    {
      get { return id; }
    }

    private string kutyanev;

    public string Kutyanev
    {
      get { return kutyanev; }
    }

    public Nev(int id, string kutyanev)
    {
      this.id = id;
      this.kutyanev = kutyanev;
    }
  }
}
