using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Hilos
{
    public partial class Form1 : Form
    {

        Thread Carrera;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                Carrera.Start();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

        }

        private void cmdPausar_Click(object sender, EventArgs e)
        {
            try
            {
                Carrera.Suspend();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void cmdRenudar_Click(object sender, EventArgs e)
        {
            try
            {
                Carrera.Resume();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void cmdAbortar_Click(object sender, EventArgs e)
        {
            try
            {
                Carrera.Abort();

                shrek.Left = 0;
                chettah.Left = 0;
                jugador.Left = 0;
                corredor.Left = 0;
                elefante.Left = 0;
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            Carrera = new Thread(new ThreadStart(Moverse));
        }

        public void Moverse()
        {
            int meta = this.Width - shrek.Width - 100;
            bool c1 = false, c2 = false, c3 = false, c4 = false, c5 = false;
            Random rd = new Random();
            while (!c1 && !c2 && !c3 && !c4 && !c5)
            {
                shrek.Left += rd.Next(30);
                chettah.Left += rd.Next(30);
                jugador.Left += rd.Next(30);
                corredor.Left += rd.Next(30);
                elefante.Left += rd.Next(30);
                c1 = shrek.Left >= meta;
                c2 = chettah.Left >= meta;
                c3 = jugador.Left >= meta;
                c4 = corredor.Left >= meta;
                c5 = elefante.Left >= meta;
                Thread.Sleep(50);
            }
            if (c1) MessageBox.Show("Gano shrek");
            else if (c2) MessageBox.Show("Gano chettah");
            else if (c3) MessageBox.Show("Gano jugador");
            else if (c4) MessageBox.Show("Gano corredor");
            else MessageBox.Show("Gano elefante");

        }

        private void cmdReiniciar_Click(object sender, EventArgs e)
        {
            shrek.Left = 0;
            chettah.Left = 0;
            jugador.Left = 0;
            corredor.Left = 0;
            elefante.Left = 0;

            Carrera.Suspend();
           
        }
    }
}
