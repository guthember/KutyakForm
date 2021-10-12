using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakForm
{
  class Fajta
  {
    private int id;

    public int Id
    {
      get { return id; }
    }

    private string fajtanev;

    public string Fajtanev
    {
      get { return fajtanev; }
    }

    private string eredetinev;

    public string Eredetinev
    {
      get { return eredetinev; }
    }

    public Fajta(int id, string fajtanev, string eredetinev)
    {
      this.id = id;
      this.fajtanev = fajtanev;
      this.eredetinev = eredetinev;
    }
  }
}
