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
    public partial class frmUnidad : Form
    {
        public frmUnidad()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"server=(localdb)\clinica; Initial Catalog=clinica; integrated security=true");

        private void cmdregresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUnidad_Load(object sender, EventArgs e)
        {
            CargarUnDatagrid();
        }

        void CargarUnDatagrid()
        {

            //definir la consulta sql server
            string sql = "select * from unidad";

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
            SqlCommand altas = new SqlCommand("insert into unidad (num_unidad, nom_unidad, planta) values (@num_unidad, @nom_unidad, @planta)", conexion);

            altas.Parameters.AddWithValue("num_unidad", txtnum_unidad.Text);
            altas.Parameters.AddWithValue("nom_unidad", txtnom_unidad.Text);
            altas.Parameters.AddWithValue("planta", txtplanta.Text);

            altas.ExecuteNonQuery();

            txtnum_unidad.Text = "";
            txtnom_unidad.Text = "";
            txtplanta.Text = "";

            MessageBox.Show("Unidad dado de alta");

            conexion.Close();
        }

        private void baja_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string baja = "DELETE FROM unidad WHERE num_unidad = @num_unidad";

            SqlCommand cmdbaja = new SqlCommand(baja, conexion);
            cmdbaja.Parameters.Add("num_unidad", txtnum_unidad.Text);
            cmdbaja.ExecuteNonQuery();

            cmdbaja.Dispose();
            cmdbaja = null;
            txtnum_unidad.Clear();
            txtnom_unidad.Clear();
            txtplanta.Clear();
            txtnum_unidad.Focus();
            conexion.Close();

            MessageBox.Show("Se doy de baja");
        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            String consulta = "select * from unidad where num_unidad=" + txtnum_unidad.Text;
            SqlCommand cmdconsulta = new SqlCommand(consulta, conexion);

            try
            {
                SqlDataReader Reade = cmdconsulta.ExecuteReader();
                Reade.Read();
                txtnom_unidad.Text = Reade.GetValue(1).ToString();
                txtplanta.Text = Reade.GetValue(2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro");

            }

            conexion.Close();
        }

        private void modificacion_Click(object sender, EventArgs e)
        {
            if (txtnum_unidad.Text == "" || txtnom_unidad.Text == "" || txtplanta.Text == "")
            {
                MessageBox.Show("Llenar todos los campos");
            }
            else
            {
                conexion.Open();
                string id = txtnum_unidad.Text;
                string nombre = txtnom_unidad.Text;
                string planta = txtplanta.Text;
                string cadena = "update unidad set nom_unidad='" + nombre + "', planta='" + planta + "' where num_unidad=" + id;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del paciente");
                    txtnum_unidad.Clear();
                    txtnom_unidad.Clear();
                    txtplanta.Clear();
                    txtnum_unidad.Focus();

                }
                else
                    MessageBox.Show("No existe un paciente con el id ingresado");
                conexion.Close();
            }
        }
    }
}
