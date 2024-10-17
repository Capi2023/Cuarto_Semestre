using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace clinica
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"server=(localdb)\clinica; Initial Catalog=clinica; integrated security=true");

        private void cmdregresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlCommand cmd;
        SqlDataReader dr;

        private void BindComboBox_Load(object sender, EventArgs e)
        {
        }

        public void BindDataempleado()
        {
            cmd = new SqlCommand("select id_empleado from empleados", conexion);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboid_empleado.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        public void BindDatapaciente()
        {
            cmd = new SqlCommand("select id_paciente from pacientes", conexion);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboid_paciente.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            conexion.Open();

            BindDataempleado();
            BindDatapaciente();
            conexion.Close();
            CargarUnDatagrid();
        }

        void CargarUnDatagrid()
        {

            //definir la consulta sql server
            string sql = "select * from reporte_de_seguimiento";

            try
            {
                //abrir conexion
                conexion.Open();

                //definimos el adaptador para almacenar la información
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conexion);
                DataTable dt = new DataTable();

                //cargamos la tabla en memoria "data table" con la información del adaptador    
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;                        //cargamos el datagrid                 
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        private void Subida_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            SqlCommand altas = new SqlCommand("insert into reporte_de_seguimiento (num_reporte, fecha, sintomas, tratamiento, evolucion, id_paciente, id_empleado) values (@num_reporte, @fecha, @sintomas, @tratamiento, @evolucion, @id_paciente, @id_empleado)", conexion);

            altas.Parameters.AddWithValue("num_reporte", txtnum_reporte.Text);
            altas.Parameters.AddWithValue("fecha", datetFecha.Value);
            altas.Parameters.AddWithValue("sintomas", txtsintomas.Text);
            altas.Parameters.AddWithValue("tratamiento", txttratamiento.Text);
            altas.Parameters.AddWithValue("evolucion", txtevolucion.Text);
            altas.Parameters.AddWithValue("id_paciente", comboid_paciente.Text);
            altas.Parameters.AddWithValue("id_empleado", comboid_empleado.Text);

            altas.ExecuteNonQuery();

            txtnum_reporte.Text = "";
            txtsintomas.Text = "";
            txttratamiento.Text = "";
            txtevolucion.Text = "";
            comboid_paciente.Text = "";
            comboid_empleado.Text = "";

            MessageBox.Show("Reporte dado de alta");

            conexion.Close();
        }

        private void baja_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string baja = "DELETE FROM reporte_de_seguimiento WHERE num_reporte = @num_reporte";

            SqlCommand cmdbaja = new SqlCommand(baja, conexion);
            cmdbaja.Parameters.Add("num_reporte", txtnum_reporte.Text);
            cmdbaja.ExecuteNonQuery();

            cmdbaja.Dispose();
            cmdbaja = null;
            txtnum_reporte.Clear();
            txtsintomas.Clear();
            txttratamiento.Clear();
            txtevolucion.Clear();
            txtnum_reporte.Focus();
            conexion.Close();

            MessageBox.Show("Se dio de baja");
        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            String consulta = "select * from reporte_de_seguimiento where num_reporte=" + txtnum_reporte.Text;
            SqlCommand cmdconsulta = new SqlCommand(consulta, conexion);

            try
            {
                SqlDataReader Reade = cmdconsulta.ExecuteReader();
                Reade.Read();
                datetFecha.Text = Reade.GetValue(1).ToString();
                txtsintomas.Text = Reade.GetValue(2).ToString();
                txttratamiento.Text = Reade.GetValue(3).ToString();
                txtevolucion.Text = Reade.GetValue(4).ToString();
                comboid_paciente.Text = Reade.GetValue(5).ToString();
                comboid_empleado.Text = Reade.GetValue(6).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro");

            }

            conexion.Close();
        }

        private void modificacion_Click(object sender, EventArgs e)
        {
            if (txtnum_reporte.Text == "" || comboid_paciente.Text == "" || comboid_empleado.Text == "" || datetFecha.Text == "" || txtsintomas.Text == "" || txttratamiento.Text == "" || txtevolucion.Text == "")
            {
                MessageBox.Show("Llenar todos los campos");
            }
            else
            {

                conexion.Open();
                string id = txtnum_reporte.Text;
                string id_paciente = comboid_paciente.Text;
                string id_empleado = comboid_empleado.Text;
                string fecha = datetFecha.Text;
                string sintomas = txtsintomas.Text;
                string tratamiento = txttratamiento.Text;
                string evolucion = txtevolucion.Text;
                string cadena = "update reporte_de_seguimiento set id_paciente='" + id_paciente + "', id_empleado='" + id_empleado + "', fecha='" + fecha + "', sintomas='" + sintomas + "', tratamiento='" + tratamiento + "', evolucion='" + evolucion + "' where num_reporte=" + id;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del reporte del paciente");
                    txtnum_reporte.Clear();
                    txtsintomas.Clear();
                    txttratamiento.Clear();
                    txtevolucion.Clear();
                    txtnum_reporte.Focus();

                }
                else
                    MessageBox.Show("No existe un reporte con el id ingresado");
                conexion.Close();
            }
        }
    }
}
