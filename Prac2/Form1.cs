using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac2
{
    public partial class Form1 : Form
    {
        private int Ancho = 80;
        private int Altura = 30;
        private int PosX = 180;
        private int PosY = 120;
        private int MovX = 3;
        private int MovY = 3;
        public Form1()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.UpdateStyles();
        }

        private void cmdBoton_Click(object sender, EventArgs e)
        {

        }

        private void Mover(object sender, EventArgs e)
        {
            PosX += MovX;
            if (PosX < 0 || PosX + Ancho > this.ClientSize.Width)
            {
                MovX = -MovX;
            }

            PosY += MovY;
            if (PosY < 0 || PosY + Altura > this.ClientSize.Height)
            {
                MovY = -MovY;
            }

            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hm(object sender, PaintEventArgs e)
        {

        }

        private void va(object sender, PaintEventArgs e)
        {
            cmdBoton.Location = new Point(PosX, PosY);
        }
    }
}
