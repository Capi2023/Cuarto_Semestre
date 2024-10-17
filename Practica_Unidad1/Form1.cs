using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Unidad1
{
    public partial class Form1 : Form
    {
        private int Ancho1 = 75;
        private int Altura1 = 75;
        private int PosX1 = 75;
        private int PosY1 = 50;
        private int MovX1 = 3;
        private int MovY1 = 3;

        private int Ancho2 = 75;
        private int Altura2 = 75;
        private int PosX2 = 445;
        private int PosY2 = 84;
        private int MovX2 = 3;
        private int MovY2 = 3;
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.UpdateStyles();
        }

        private void Mover1(object sender, EventArgs e)
        {
            //Boton principal
            PosX1 += MovX1;
            //X
            if (PosX1 < 0 || PosX1 + Ancho1 > this.ClientSize.Width || PosX1 == PosX2 + Ancho2 || PosX1 + Ancho1 == PosX2)
            {
                MovX1 = -MovX1;
            }

            //Y
            PosY1 += MovY1;
            if (PosY1 < 0 || PosY1 + Altura1 > this.ClientSize.Height || PosY1 == PosY2 + Altura2 || PosY1 + Altura1 == PosY2)
            {
                MovY1 = -MovY1;
            }

            //Boton 2
            PosX2 += MovX2;
            //X


            if (PosX2 < 0 || PosX2 + Ancho2 > this.ClientSize.Width || PosX1 == PosX2 + Ancho2 || PosX1 + Ancho1 == PosX2)
            {
                MovX2 = -MovX2;
            }

            //Y
            PosY2 += MovY2;
            if (PosY2 < 0 || PosY2 + Altura2 > this.ClientSize.Height || PosY1 == PosY2 + Altura2 || PosY1 + Altura1 == PosY2)
            {
                MovY2 = -MovY2;
            }


            this.Refresh();
        }

        private void Actualiza(object sender, PaintEventArgs e)
        {
            cmdBtn1.Location = new Point(PosX1, PosY1);
            cmdBtn2.Location = new Point(PosX2, PosY2);
        }
    }
}
