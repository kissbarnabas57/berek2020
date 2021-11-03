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

namespace berek2020
{
  public partial class Form1 : Form
  {
    List<Berek> lista = new List<Berek>();
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      Beolvasas();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      HetedikFeladat();
  
    }

    private void HetedikFeladat()
    {
      Dictionary<string, int> stat = new Dictionary<string, int>();

      stat.Add("beszerzés", 17);
      stat.Add("pénzügy", 36);
      stat.Add("asztalosműhely", 18);
      stat.Add("értékesítés", 16);
      stat.Add("lakatosműhely", 15);
      stat.Add("karbantartás", 26);
      stat.Add("szerelőműhely", 30);
      stat.Add("személyzeti", 12);

      
    }

    private void HatodikFeladat()
    {
      int max;
      for (int i = 0; i < lista.Count; i++)
      {
        if ()
        {

        }
      }
    }

    private void OtodikFeladat()
    {
      
    }

    private void NegyedikFeladat()
    {
      int sum = 0;
      foreach (var l in lista)
      {
       
      }
    }

    private void HarmadikFeladat()
    {
      lblDolgozo.Text = $"{lista.Count } fő";
    }

    private void Beolvasas()
    {
      StreamReader be = new StreamReader("berek2020.txt");
      be.ReadLine();
      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');
        lista.Add(new Berek(a[0],a[1],a[2],Convert.ToInt32(a[3]),Convert.ToInt32(a[4])));
      }
      be.Close();
    }
  }
}
