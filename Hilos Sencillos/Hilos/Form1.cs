using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;//Para Manejar hilos

namespace Hilos
{
    
    public partial class Form1 : Form
    { 
        //variables utilizadas
        int a=0,b=0,c=0,d=0;


        //definir diferentes procesos
        Thread proceso_1; 
        Thread proceso_2;
        Thread proceso_3;
        Thread proceso_4;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            proceso_1 = new Thread(new ThreadStart(funcion_1));
            proceso_2 = new Thread(new ThreadStart(funcion_2));
            proceso_3 = new Thread(new ThreadStart(funcion_3));
            proceso_4 = new Thread(new ThreadStart(funcion_4));

        }


        public void funcion_1() 
        {

            while (true)
            {
                Thread.Sleep(220);

                a++; label5.Text = Convert.ToString(a);
                
            }

        }

        public void funcion_2() 
        {
            while (true)
            {
                Thread.Sleep(110);

                b++; label6.Text = Convert.ToString(b);
                
            }
        }

        public void funcion_3() 
        {
            while (true)
            {
                Thread.Sleep(60);

                c++; label7.Text = Convert.ToString(c);
                
            }
        }

        public void funcion_4() 
        {
            while (true)
            {
                Thread.Sleep(10);

                d++; label8.Text = Convert.ToString(d);
                
            }
        }









// CODIGOS DE LOS BOTONES 1
        private void button1_Click_1(object sender, EventArgs e) //INICIAR
        {
            try
            {
                proceso_1.Start();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)//PAUSA
        {
            try
            {
                proceso_1.Suspend();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)//REINICIAR
        {
            try
            {
                proceso_1.Resume();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)//ABORTAR
        {
            try
            {
                proceso_1.Abort();
                a = 0;

                label5.Text = "0"; 
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }





        // CODIGOS DE LOS BOTONES 2
        private void button8_Click(object sender, EventArgs e)//INICIAR
        {
            try
            {
                proceso_2.Start();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)//PAUSA
        {
            try
            {
                proceso_2.Suspend();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)//REINICIAR
        {
            try
            {
                proceso_2.Resume();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)//ABORTAR
        {
            try
            {
                proceso_2.Abort();
                b = 0;

                label6.Text = "0";
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }







        // CODIGOS DE LOS BOTONES 3
        private void button12_Click(object sender, EventArgs e)//INICIAR
        {
            try
            {
                proceso_3.Start();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)//PAUSA
        {
            try
            {
                proceso_3.Suspend();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)//REINICIAR
        {
            try
            {
                proceso_3.Resume();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)//ABORTAR
        {
            try
            {
                proceso_3.Abort();
                c = 0;

                label7.Text = "0"; 
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }



        // CODIGOS DE LOS BOTONES 4
        private void button16_Click(object sender, EventArgs e)//INICIAR
        {
            try
            {
                proceso_4.Start();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)//PAUSA
        {
            try
            {
                proceso_4.Suspend();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            } 
        }

        private void button14_Click(object sender, EventArgs e)//REINICIAR
        {
            try
            {
                proceso_4.Resume();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)//ABORTAR
        {
            try
            {
                proceso_4.Abort();
                d = 0;

                label8.Text = "0";
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }
        




    }
}
