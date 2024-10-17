using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace PRACTICA2
{
    public partial class PRACTICA2 : Form
    {
        private int Ancho = 358;
        private int Altura = 424;
        private int PosX = 0;
        private int PosY = 0;
        private int MoverX = 20;
        private int MoverY = 20;

        public PRACTICA2()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint,
                true
                );

            this.UpdateStyles();
        }

       

        private void cmdBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felicidades, lograste pulsar el boton");
        }

        private void PRACTICA2_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            cmdBoton.Location = new Point(PosX, PosY);
        }

        private void Paicmd(object sender, PaintEventArgs e)
        {

        }

        private void Move(object sender, EventArgs e)
        {
            PosX += MoverX;
            if (PosX < 0 || PosX + Ancho > this.ClientSize.Width)
            {
                MoverX = -MoverX;
            }

            PosY += MoverY;
            if (PosY < 0 || PosY + Altura > this.ClientSize.Height)
            {
                MoverY = -MoverY;
            }

            this.Refresh();
        }
    }
}
