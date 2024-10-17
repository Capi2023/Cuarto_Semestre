using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        frmClientes Cli = new frmClientes();
        frmHoteles Ho = new frmHoteles();
        frmCategorias Cat = new frmCategorias();
        frmHabitaciones Hab = new frmHabitaciones();
        frmReservaciones Res = new frmReservaciones();

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdClientes_Click(object sender, EventArgs e)
        {
            AbrirFormClienteInPanel(new frmClientes());
        }

        private void cmdReservaciones_Click(object sender, EventArgs e)
        {
            AbrirFormReservacionesInPanel(new frmReservaciones());
        }

        private void cmdHabitaciones_Click(object sender, EventArgs e)
        {
            AbrirFormHabitacionesInPanel(new frmHabitaciones());
        }

        private void cmdCategorias_Click(object sender, EventArgs e)
        {

            AbrirFormCategoriasInPanel(new frmCategorias());
        }

        private void cmdHoteles_Click(object sender, EventArgs e)
        {
            AbrirFormHotelesInPanel(new frmHoteles());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormClienteInPanel(object frmClientes)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fc = frmClientes as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fc);
            this.panel2.Tag = fc;
            fc.Show();
        }

        private void AbrirFormHabitacionesInPanel(object frmHabitaciones)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = frmHabitaciones as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }


        private void AbrirFormHotelesInPanel(object frmHoteles)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = frmHoteles as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }


        private void AbrirFormCategoriasInPanel(object frmCategorias)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = frmCategorias as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }


        private void AbrirFormReservacionesInPanel(object frmReservaciones)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = frmReservaciones as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }
    }
}
