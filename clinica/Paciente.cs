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
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"server=(localdb)\clinica; Initial Catalog=clinica; integrated security=true");


        private void cmdregresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void CargarUnDatagrid()
        {

            //definir la consulta sql server
            string sql = "select * from pacientes";

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

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            CargarUnDatagrid();

        }

        private void Subida_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            SqlCommand altas = new SqlCommand("insert into pacientes (id_paciente, nombre, numero_SS, edad, fecha_de_ingreso) values (@id_paciente, @nombre, @numero_SS, @edad, @fecha_de_ingreso)", conexion);

            altas.Parameters.AddWithValue("id_paciente", txtid.Text);
            altas.Parameters.AddWithValue("nombre", txtnombre.Text);
            altas.Parameters.AddWithValue("numero_SS", txtSS.Text);
            altas.Parameters.AddWithValue("edad", txtedad.Text);
            altas.Parameters.AddWithValue("fecha_de_ingreso", txtfecha.Text);

            altas.ExecuteNonQuery();

            txtid.Clear();
            txtnombre.Clear();
            txtSS.Clear();
            txtedad.Clear();
            txtfecha.Clear();

            MessageBox.Show("Paciente dado de alta");

            conexion.Close();
        }

        private void baja_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string baja = "DELETE FROM pacientes WHERE id_paciente = @id_paciente";

            SqlCommand cmdbaja = new SqlCommand(baja, conexion);
            cmdbaja.Parameters.Add("id_paciente", txtid.Text);
            cmdbaja.ExecuteNonQuery();

            cmdbaja.Dispose();
            cmdbaja = null;
            txtid.Clear();
            txtnombre.Clear();
            txtSS.Clear();
            txtedad.Clear();
            txtfecha.Clear();
            txtid.Focus();
            conexion.Close();

            MessageBox.Show("Se doy de baja");
        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            String consulta = "select * from pacientes where id_paciente=" + txtid.Text;
            SqlCommand cmdconsulta = new SqlCommand(consulta, conexion);

            try
            {
                SqlDataReader Reade = cmdconsulta.ExecuteReader();
                Reade.Read();
                txtnombre.Text = Reade.GetValue(1).ToString();
                txtSS.Text = Reade.GetValue(2).ToString();
                txtedad.Text = Reade.GetValue(3).ToString();
                txtfecha.Text = Reade.GetValue(4).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro");

            }

            conexion.Close();
        }

        private void modificacion_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtnombre.Text == "" || txtSS.Text == "" || txtedad.Text == "" || txtfecha.Text == "")
            {
                MessageBox.Show("Llenar todos los campos");
            }
            else
            {

                conexion.Open();
                string id = txtid.Text;
                string nombre = txtnombre.Text;
                string SS = txtSS.Text;
                string edad = txtedad.Text;
                string fecha = txtfecha.Text;
                string cadena = "update pacientes set nombre='" + nombre + "', numero_SS='" + SS + "', edad='" + edad + "', fecha_de_ingreso='" + fecha + "' where id_paciente=" + id;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del paciente");
                    txtid.Clear();
                    txtnombre.Clear();
                    txtSS.Clear();
                    txtedad.Clear();
                    txtfecha.Clear();
                    txtid.Focus();

                }
                else
                    MessageBox.Show("No existe un paciente con el id ingresado");
                conexion.Close();
            }
        }
    }
}
