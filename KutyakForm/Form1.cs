using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KutyakForm
{
  public partial class Form1 : Form
  {
    List<Fajta> fajtak = new List<Fajta>();
    List<Nev> nevek = new List<Nev>();
    List<Kutya> kutyak = new List<Kutya>();
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      FajtakBeolvasasa();
      NevekBeolvasasa();
      KutyakBeolvasasa();
    }

    private void KutyakBeolvasasa()
    {
      StreamReader be = new StreamReader("kutyak.csv");

      be.ReadLine();

      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');

        kutyak.Add(new Kutya(
            Convert.ToInt32(a[0]), Convert.ToInt32(a[1]),
            Convert.ToInt32(a[2]), Convert.ToInt32(a[3]),
            Convert.ToDateTime(a[4]), fajtak, nevek
          ));
      }

      be.Close();
    }

    private void NevekBeolvasasa()
    {
      StreamReader be = new StreamReader("kutyanevek.csv");

      be.ReadLine();

      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');

        nevek.Add(new Nev(
            Convert.ToInt32(a[0]), a[1]
          ));
      }

      be.Close();
    }

    private void FajtakBeolvasasa()
    {
      StreamReader be = new StreamReader("kutyafajtak.csv");

      be.ReadLine();

      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');

        fajtak.Add(new Fajta(
            Convert.ToInt32(a[0]),a[1],a[2]
          ));
      }


      be.Close();
    }
  }
}
