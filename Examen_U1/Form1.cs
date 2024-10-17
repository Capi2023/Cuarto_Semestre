using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_U1
{
    public partial class Form1 : Form
    {
        private int PosX = 75;
        private int PosY = 75;
        private int MovX = 2;
        private int MovY = 2;
        private int Ancho = 75;
        private int Altura = 23;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdBtn3_Click(object sender, EventArgs e)
        {

        }

        private void cmdBtn1_Click(object sender, EventArgs e)
        {
            MovX = MovX + 1;
            MovY = MovY + 1;
        }

        private void cmdBtn4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdBtn2_Click(object sender, EventArgs e)
        {
            cmdBtn3.BackColor = Color.Red;
        }

        private void Iniciar(object sender, PaintEventArgs e)
        {
            cmdBtn3.Location = new Point(PosX, PosY);
        }

        private void Mover(object sender, EventArgs e)
        {
            PosX += MovX;
            if (PosX < 0 || PosX + Ancho > this.ClientSize.Width)
            {
                MovX = -MovX;
                Derecha();
                Izquierda();
            }

            PosY += MovY;
            if (PosY < 0 || PosY + Altura > this.ClientSize.Height)
            {
                MovY = -MovY;
                Derecha();
                Izquierda();
            }
            this.Refresh();
        }

        private void Derecha()
        {
            if (PosX + Ancho > this.ClientSize.Width)
            {   
                this.BackColor = Color.Yellow;
            }
        }

        private void Izquierda()
        {
            if (PosX < 0)
            {
                this.BackColor = Color.Blue;
            }
        }
    }
}
