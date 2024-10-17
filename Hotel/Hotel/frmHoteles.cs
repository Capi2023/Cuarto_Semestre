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

namespace Hotel
{
    public partial class frmHoteles : Form
    {
        public frmHoteles()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"server=(localdb)\clinica; Initial Catalog=Hotel; integrated security=true");

        private void frmHoteles_Load(object sender, EventArgs e)
        {
            CargarUnDatagrid();
        }

        private void cmdcargar_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            SqlCommand altas = new SqlCommand("insert into Hoteles (id_hotel, nombre, direccion, telefono) values (@id_hotel, @nombre, @direccion, @telefono)", conexion);

            altas.Parameters.AddWithValue("id_hotel", txtid_hotel.Text);
            altas.Parameters.AddWithValue("nombre", txtnombre.Text);
            altas.Parameters.AddWithValue("direccion", txtdireccion.Text);
            altas.Parameters.AddWithValue("telefono", txttelefono.Text);

            altas.ExecuteNonQuery();

            txtid_hotel.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtid_hotel.Focus();

            MessageBox.Show("Hotel dado de alta");

            conexion.Close();
        }

        private void cmdbaja_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string baja = "DELETE FROM Hoteles WHERE id_hotel = @id_hotel";

            SqlCommand cmdbaja = new SqlCommand(baja, conexion);
            cmdbaja.Parameters.Add("id_hotel", txtid_hotel.Text);
            cmdbaja.ExecuteNonQuery();

            cmdbaja.Dispose();
            cmdbaja = null;
            txtid_hotel.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtid_hotel.Focus();
            conexion.Close();

            MessageBox.Show("Se dio de baja");
        }

        private void cmdmodificacion_Click(object sender, EventArgs e)
        {
            if (txtid_hotel.Text == "" || txtnombre.Text == "" || txtdireccion.Text == "" || txttelefono.Text == "")
            {
                MessageBox.Show("Llenar todos los campos");
            }
            else
            {

                conexion.Open();
                string id = txtid_hotel.Text;
                string nombre = txtnombre.Text;
                string direccion = txtdireccion.Text;
                string telefono = txttelefono.Text;
                string cadena = "update Hoteles set nombre='" + nombre + "', direccion='" + direccion + "', telefono='" + telefono + "' where id_hotel=" + id;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del hotel");
                    txtid_hotel.Clear();
                    txtnombre.Clear();
                    txtdireccion.Clear();
                    txttelefono.Clear();
                    txtid_hotel.Focus();

                }
                else
                    MessageBox.Show("No existe un hotel con el id ingresado");
                conexion.Close();
            }
        }

        private void cmdconsulta_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            String consulta = "select * from Hoteles where id_hotel=" + txtid_hotel.Text;
            SqlCommand cmdconsulta = new SqlCommand(consulta, conexion);

            try
            {
                SqlDataReader Reade = cmdconsulta.ExecuteReader();
                Reade.Read();
                txtnombre.Text = Reade.GetValue(1).ToString();
                txtdireccion.Text = Reade.GetValue(2).ToString();
                txttelefono.Text = Reade.GetValue(3).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro");

            }

            conexion.Close();
        }

        void CargarUnDatagrid()
        {

            //definir la consulta sql server
            string sql = "select * from Hoteles";

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
    }
}
