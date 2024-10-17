using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form1 : Form
    {
        private int Ancho = 25;
        private int Altura = 23;
        private int PosX = 400;
        private int PosY = 225;
        private int MovX = 3;
        private int MovY = 3;

        private int Ancho1 = 75;
        private int Altura1 = 23;
        private int PosX1 = 615;
        private int PosY1 = 103;
        private int MovX1 = 2;
        private int MovY1 = 2;

        private int Ancho2 = 75;
        private int Altura2 = 23;
        private int PosX2 = 35;
        private int PosY2 = 40;
        private int MovX2 = 3;
        private int MovY2 = 3;

        private int Ancho3 = 75;
        private int Altura3 = 23;
        private int PosX3 = 82;
        private int PosY3 = 369;
        private int MovX3 = 4;
        private int MovY3 = 4;

        private int Ancho4 = 75;
        private int Altura4 = 23;
        private int PosX4 = 587;
        private int PosY4 = 359;
        private int MovX4 = 5;
        private int MovY4 = 5;

        private int Ancho5 = 75;
        private int Altura5 = 23;
        private int PosX5 = 452;
        private int PosY5 = 286;
        private int MovX5 = 1;
        private int MovY5 = 1;

        private int Ancho6 = 139;
        private int Altura6 = 98;
        private int PosX6 = 288;
        private int PosY6 = 28;
        private int MovX6 = 1;
        private int MovY6 = 1;

        private int Ancho7 = 178;
        private int Altura7 = 143;
        private int PosX7 = 600;
        private int PosY7 = 183;
        private int MovX7 = 3;
        private int MovY7 = 3;

        private int Ancho8 = 103;
        private int Altura8 = 110;
        private int PosX8 = 32;
        private int PosY8 = 103;
        private int MovX8 = 5;
        private int MovY8 = 5;

        int opc;
        public Form1()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.UpdateStyles();
        }

        async private void cmdBoton_Click(object sender, EventArgs e)
        {
            lbladios.Text = "Hola, adios";
            await Task.Delay(4000);
            Close();
        }

        private void va(object sender, PaintEventArgs e)
        {
            cmdBoton.Location = new Point(PosX, PosY);
            cmdBtn1.Location = new Point(PosX1, PosY1);
            cmdBtn2.Location = new Point(PosX2, PosY2);
            cmdBtn3.Location = new Point(PosX3, PosY3);
            cmdBtn4.Location = new Point(PosX4, PosY4);
            cmdBtn5.Location = new Point(PosX5, PosY5);
            pct1.Location = new Point(PosX6, PosY6);
            pct2.Location = new Point(PosX7, PosY7);
            pct3.Location = new Point(PosX8, PosY8);
        }

        private void Mover(object sender, EventArgs e)
        {
            //Boton principal
            PosX += MovX;
            if (PosX < 0 || PosX + Ancho > this.ClientSize.Width)
            {
                MovX = -MovX;
                opc = 0;
                CondicionX();
            }

            PosY += MovY;
            if (PosY < 0 || PosY + Altura > this.ClientSize.Height)
            {
                MovY = -MovY;
                opc = 0;
                CondicionY();
            }

            //Boton 1
            PosX1 += MovX1;
            if (PosX1 < 0 || PosX1 + Ancho1 > this.ClientSize.Width)
            {
                MovX1 = -MovX1;
            }

            PosY1 += MovY1;
            if (PosY1 < 0 || PosY1 + Altura1 > this.ClientSize.Height)
            {
                MovY1 = -MovY1;
            }


            //Boton 2
            PosX2 += MovX2;
            if (PosX2 < 0 || PosX2 + Ancho2 > this.ClientSize.Width)
            {
                MovX2 = -MovX2;
            }

            PosY2 += MovY2;
            if (PosY2 < 0 || PosY2 + Altura2 > this.ClientSize.Height)
            {
                MovY2 = -MovY2;
            }

            //Boton 3
            PosX3 += MovX3;
            if (PosX3 < 0 || PosX3 + Ancho3 > this.ClientSize.Width)
            {
                MovX3 = -MovX3;
            }

            PosY3 += MovY3;
            if (PosY3 < 0 || PosY3 + Altura3 > this.ClientSize.Height)
            {
                MovY3 = -MovY3;
            }

            //Boton 4
            PosX4 += MovX4;
            if (PosX4 < 0 || PosX4 + Ancho4 > this.ClientSize.Width)
            {
                MovX4 = -MovX4;
            }

            PosY4 += MovY4;
            if (PosY4 < 0 || PosY4 + Altura4 > this.ClientSize.Height)
            {
                MovY4 = -MovY4;
            }


            //Boton 5
            PosX5 += MovX5;
            if (PosX5 < 0 || PosX5 + Ancho5 > this.ClientSize.Width)
            {
                MovX5 = -MovX5;
            }

            PosY5 += MovY5;
            if (PosY5 < 0 || PosY5 + Altura5 > this.ClientSize.Height)
            {
                MovY5 = -MovY5;
            }


            //Imagen 1
            PosX6 += MovX6;
            if (PosX6 < 0 || PosX6 + Ancho6 > this.ClientSize.Width)
            {
                MovX6 = -MovX6;
            }

            PosY6 += MovY6;
            if (PosY6 < 0 || PosY6 + Altura6 > this.ClientSize.Height)
            {
                MovY6 = -MovY6;
            }


            //Imagen 2
            PosX7 += MovX7;
            if (PosX7 < 0 || PosX7 + Ancho7 > this.ClientSize.Width)
            {
                MovX7 = -MovX7;
            }

            PosY7 += MovY7;
            if (PosY7 < 0 || PosY7 + Altura7 > this.ClientSize.Height)
            {
                MovY7 = -MovY7;
            }


            //Imagen 3
            PosX8 += MovX8;
            if (PosX8 < 0 || PosX8 + Ancho8 > this.ClientSize.Width)
            {
                MovX8 = -MovX8;
            }

            PosY8 += MovY8;
            if (PosY8 < 0 || PosY8 + Altura8 > this.ClientSize.Height)
            {
                MovY8 = -MovY8;
            }

            this.Refresh();
        }


        //Condicion de x
        private void CondicionX()
        {
            DESU();
            DEIN();
            IZSU();
            IZIN();
            if (opc >= 1)
            {
                Der();
                Izq();
            }
        }


        //Condicion de y
        private void CondicionY()
        {
            DESU();
            DEIN();
            IZSU();
            IZIN();
            if (opc >= 1)
            {
                Down();
                Arriba();
            }
        }


        //PARTE SUPERIOR
        private void Arriba()
        {
            if (PosY < this.ClientSize.Height/2)
            {
                this.BackColor = Color.Purple;
                pct1.Visible = true;
                pct2.Visible = true;
                pct3.Visible = true;
            }
        }

        //PARTE INFERIOR
        private void Down()
        {
            if (PosY > this.ClientSize.Height / 2)
            {
                lbl1.Text = "Aqui estoy";
                lbl2.Text = "O aqui";
                lbl3.Text = "Por aqui";
                this.BackColor = Color.Yellow;
            }
        }

        //LADO DERECHO
        private void Der()
        {
            if ( PosX > this.ClientSize.Width/2)
            {
                this.BackColor = Color.Orange;
                cmdBtn1.Visible = true;
                cmdBtn2.Visible = true;
                cmdBtn3.Visible = true;
                cmdBtn4.Visible = true;
                cmdBtn5.Visible = true;
            }
        }

        //LADO IZQUIERDO
        private void Izq()
        {
            if (PosX < this.ClientSize.Width / 2)
            {
                cmdBoton.Text = "";
                lbl1.Text = "";
                lbl2.Text = "";
                lbl3.Text = "";
                cmdBtn1.Visible = false;
                cmdBtn2.Visible = false;
                cmdBtn3.Visible = false;
                cmdBtn4.Visible = false;
                cmdBtn5.Visible = false;
                pct1.Visible = false;
                pct2.Visible = false;
                pct3.Visible = false;
                this.BackColor = Color.White;
            }
        }

        //ESQUINA SUPERIOR DERECHA
        private void DESU()
        {
            if (PosY <= (this.ClientSize.Height / 8) && PosX >= (this.ClientSize.Width - (this.ClientSize.Width / 8)))
            {
                this.BackColor = Color.Green;
                pct1.Visible = false;
                pct2.Visible = false;
                pct3.Visible = false;
                opc = -4;
            }
            else
            {
                opc = opc + 1;
            }
        }

        // ESQUINA INFERIOR DERECHA
        private void DEIN()
        {
            if (PosY >= (this.ClientSize.Height - (this.ClientSize.Height / 8)) && PosX >= (this.ClientSize.Width - (this.ClientSize.Width / 8)))
            {
                this.BackColor = Color.Blue;
                lbl1.Text = "";
                lbl2.Text = "";
                lbl3.Text = "";
                opc = -4;
            }
            else
            {
                opc = opc + 1;
            }
        }

        //ESQUINA SUPERIOR IZQUIERDA
        async private void IZSU()
        {
            if (PosY <= (this.ClientSize.Height / 8) && PosX <= (this.ClientSize.Width / 8))
            {
                this.BackColor = Color.Red;
                await Task.Delay(300);
                this.BackColor = Color.Blue;
                await Task.Delay(300);
                this.BackColor = Color.Gray;
                await Task.Delay(300);
                this.BackColor = Color.Yellow;
                await Task.Delay(300);
                this.BackColor = Color.Black;
                await Task.Delay(300);
                this.BackColor = Color.Pink;
                opc = -4;
            }
            else
            {
                opc = opc + 1;
            }
        }

        //ESQUINA INFERIOR IZQUIERDA
        private void IZIN()
        {
            if (PosY >= (this.ClientSize.Height - (this.ClientSize.Height / 8)) && PosX <= (this.ClientSize.Width / 8))
            {
                cmdBoton.Text = "8";
                opc = -4;
            }
            else
            {
                opc = opc + 1;
            }
        }

        private void cmdBtn1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
