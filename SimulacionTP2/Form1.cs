using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionTP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtnn.Text);
            double m = double.Parse(txtnm.Text);
            double s = double.Parse(txtns.Text);

            List<double> lst = Generador.GenerarNormal(n, m, s);
            Procesar(lst);
        }

        private void btnUniforme_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtun.Text);
            double a = double.Parse(txtua.Text);
            double b = double.Parse(txtub.Text);

            List<double> lst = Generador.GenerarUniforme(n, a, b);
            Procesar(lst);
        }

        private void btnExponencial_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txten.Text);
            double l = double.Parse(txtel.Text);

            List<double> lst = Generador.GenerarExponencial(n, l);
            Procesar(lst);
        }

        private void btnPoisson_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtpn.Text);
            double l = double.Parse(txtpl.Text);

            List<double> lst = Generador.GenerarPoisson(n, l);
            Procesar(lst);
        }

        private void Procesar(List<double> lst)
        {
            List<double> l0_10 = new List<double>();
            List<double> l10_20 = new List<double>();
            List<double> l20_30 = new List<double>();
            List<double> l30_40 = new List<double>();
            List<double> l40_50 = new List<double>();
            List<double> l50_60 = new List<double>();
            List<double> l60_70 = new List<double>();
            List<double> l70_80 = new List<double>();
            List<double> l80_90 = new List<double>();
            List<double> l90_100 = new List<double>();

            double max = lst.Max();
            double min = lst.Min();

            double intervalo = (max - min) / 10;

            foreach (double d in lst)
            {
                dataGridView1.Rows.Add(d);

                if (d < min + intervalo)
                {
                    l0_10.Add(d);
                }
                else if (d < min + intervalo*  2)
                {
                    l10_20.Add(d);
                }
                else if (d < min + intervalo * 3)
                {
                    l20_30.Add(d);
                }
                else if (d < min + intervalo * 4)
                {
                    l30_40.Add(d);
                }
                else if (d < min + intervalo * 5)
                {
                    l40_50.Add(d);
                }
                else if (d < min + intervalo * 6)
                {
                    l50_60.Add(d);
                }
                else if (d < min + intervalo * 7)
                {
                    l60_70.Add(d);
                }
                else if (d < min + intervalo * 8)
                {
                    l70_80.Add(d);
                }
                else if (d < min + intervalo * 9)
                {
                    l80_90.Add(d);
                }
                else
                {
                    l90_100.Add(d);
                }
            }

            pb1.Value = 100 * l0_10.Count / lst.Count;
            pb2.Value = 100 * l10_20.Count / lst.Count;
            pb3.Value = 100 * l20_30.Count / lst.Count;
            pb4.Value = 100 * l30_40.Count / lst.Count;
            pb5.Value = 100 * l40_50.Count / lst.Count;
            pb6.Value = 100 * l50_60.Count / lst.Count;
            pb7.Value = 100 * l60_70.Count / lst.Count;
            pb8.Value = 100 * l70_80.Count / lst.Count;
            pb9.Value = 100 * l80_90.Count / lst.Count;
            pb10.Value = 100 * l90_100.Count / lst.Count;

            lbl1.Text = pb1.Value.ToString() + "%";
            lbl2.Text = pb2.Value.ToString() + "%";
            lbl3.Text = pb3.Value.ToString() + "%";
            lbl4.Text = pb4.Value.ToString() + "%";
            lbl5.Text = pb5.Value.ToString() + "%";
            lbl6.Text = pb6.Value.ToString() + "%";
            lbl7.Text = pb7.Value.ToString() + "%";
            lbl8.Text = pb8.Value.ToString() + "%";
            lbl9.Text = pb9.Value.ToString() + "%";
            lbl10.Text = pb10.Value.ToString() + "%";

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            lbl1.Text =
            lbl2.Text =
            lbl3.Text =
            lbl4.Text =
            lbl5.Text =
            lbl6.Text =
            lbl7.Text =
            lbl8.Text =
            lbl9.Text =
            lbl10.Text =
            txtnn.Text =
            txtnm.Text =
            txtns.Text =
            txtun.Text =
            txtua.Text =
            txtub.Text =
            txten.Text =
            txtel.Text =
            txtpn.Text =
            txtpl.Text = "";

            pb1.Value =
            pb2.Value =
            pb3.Value =
            pb4.Value =
            pb5.Value =
            pb6.Value =
            pb7.Value =
            pb8.Value =
            pb9.Value =
            pb10.Value = 0;
        }
    }
}
