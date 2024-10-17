using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica
{
    public partial class frmMenu : Form
    {
        frmPaciente Pac = new frmPaciente();
        frmReporte Repo = new frmReporte();
        frmdoctor_responsable Doc = new frmdoctor_responsable();
        frmempleados Emp = new frmempleados();
        frmUnidad Uni = new frmUnidad();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cmdPaciente_Click(object sender, EventArgs e)
        {
            Pac.Show();
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            Repo.Show();
        }

        private void cmdDoc_Click(object sender, EventArgs e)
        {
            Doc.Show();
        }

        private void cmdEmpleados_Click(object sender, EventArgs e)
        {
            Emp.Show();
        }

        private void cmdUnidad_Click(object sender, EventArgs e)
        {
            Uni.Show();
        }
    }
}
