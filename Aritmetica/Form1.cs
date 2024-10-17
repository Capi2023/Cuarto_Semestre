using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Librieria1;

namespace Aritmetica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MisMates mates = new MisMates(7, 6);

        private void cmdsuma_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Double.Parse(txta.Text);
            b = Double.Parse(txtb.Text);
            MisMates mates = new MisMates(a, b);
            double resultado = mates.suma();
            label1.Text = resultado.ToString();
        }

        private void cmdresta_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Double.Parse(txta.Text);
            b = Double.Parse(txtb.Text);
            MisMates mates = new MisMates(a, b);
            double resultado = mates.resta();
            label1.Text = resultado.ToString();
        }

        private void cmdmulti_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Double.Parse(txta.Text);
            b = Double.Parse(txtb.Text);
            MisMates mates = new MisMates(a, b);
            double resultado = mates.multi();
            label1.Text = resultado.ToString();
        }

        private void cmddivision_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Double.Parse(txta.Text);
            b = Double.Parse(txtb.Text);
            MisMates mates = new MisMates(a, b);
            double resultado = mates.div();
            label1.Text = resultado.ToString();
        }
    }
}
