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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"server=(localdb)\clinica; Initial Catalog=Hotel; integrated security=true");

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargarUnDatagrid();
        }

        private void cmdcargar_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            SqlCommand altas = new SqlCommand("insert into Clientes (id_cliente, nombre, direccion, telefono, email, num_tarjeta) values (@id_cliente, @nombre, @direccion, @telefono, @email, @num_tarjeta)", conexion);

            altas.Parameters.AddWithValue("id_cliente", txtid_cliente.Text);
            altas.Parameters.AddWithValue("nombre", txtnombre.Text);
            altas.Parameters.AddWithValue("direccion", txtdireccion.Text);
            altas.Parameters.AddWithValue("telefono", txttelefono.Text);
            altas.Parameters.AddWithValue("email", txtemail.Text);
            altas.Parameters.AddWithValue("num_tarjeta", txtnum_tarjeta.Text);

            altas.ExecuteNonQuery();

            txtid_cliente.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtemail.Clear();
            txtnum_tarjeta.Clear();
            txtid_cliente.Focus();

            MessageBox.Show("Cliente dado de alta");

            conexion.Close();
        }

        private void cmdbaja_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string baja = "DELETE FROM Clientes WHERE id_cliente = @id_cliente";

            SqlCommand cmdbaja = new SqlCommand(baja, conexion);
            cmdbaja.Parameters.Add("id_cliente", txtid_cliente.Text);
            cmdbaja.ExecuteNonQuery();

            cmdbaja.Dispose();
            cmdbaja = null;
            txtid_cliente.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtemail.Clear();
            txtnum_tarjeta.Clear();
            txtid_cliente.Focus();
            conexion.Close();

            MessageBox.Show("Se dio de baja");
        }

        private void cmdconsulta_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            String consulta = "select * from Clientes where id_cliente=" + txtid_cliente.Text;
            SqlCommand cmdconsulta = new SqlCommand(consulta, conexion);

            try
            {
                SqlDataReader Reade = cmdconsulta.ExecuteReader();
                Reade.Read();
                txtnombre.Text = Reade.GetValue(1).ToString();
                txtdireccion.Text = Reade.GetValue(2).ToString();
                txttelefono.Text = Reade.GetValue(3).ToString();
                txtemail.Text = Reade.GetValue(4).ToString();
                txtnum_tarjeta.Text = Reade.GetValue(5).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro");

            }

            conexion.Close();
        }

        private void cmdmodificacion_Click(object sender, EventArgs e)
        {
            if (txtid_cliente.Text == "" || txtnombre.Text == "" || txtdireccion.Text == "" || txttelefono.Text == "" || txtemail.Text == "" || txtnum_tarjeta.Text == "")
            {
                MessageBox.Show("Llenar todos los campos");
            }
            else
            {

                conexion.Open();
                string id = txtid_cliente.Text;
                string nombre = txtnombre.Text;
                string direccion = txtdireccion.Text;
                string telefono = txttelefono.Text;
                string email = txtemail.Text;
                string num_tarjeta = txtnum_tarjeta.Text;
                string cadena = "update Clientes set nombre='" + nombre + "', direccion='" + direccion + "', telefono='" + telefono + "', email='" + email + "', num_tarjeta='" + num_tarjeta + "' where id_cliente=" + id;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del cliente");
                    txtid_cliente.Clear();
                    txtnombre.Clear();
                    txtdireccion.Clear();
                    txttelefono.Clear();
                    txtemail.Clear();
                    txtnum_tarjeta.Clear();
                    txtid_cliente.Focus();

                }
                else
                    MessageBox.Show("No existe un cliente con el id ingresado");
                conexion.Close();
            }
        }

        void CargarUnDatagrid()
        {

            //definir la consulta sql server
            string sql = "select * from Clientes";

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
