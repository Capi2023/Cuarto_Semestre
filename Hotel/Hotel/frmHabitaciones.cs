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
    public partial class frmHabitaciones : Form
    {
        SqlConnection conexion = new SqlConnection(@"server=(localdb)\clinica; Initial Catalog=Hotel; integrated security=true");
        public frmHabitaciones()
        {
            InitializeComponent();
        }

        private void frmHabitaciones_Load(object sender, EventArgs e)
        {
            conexion.Open();
            Id_Categoria();
            conexion.Close();
            CargarUnDatagrid();
        }

        private void cmdcargar_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            SqlCommand altas = new SqlCommand("insert into Habitaciones (id_habitacion, id_categoria, num_cama, tipo_cama, num_baño, num_personas, costo, terraza, descripcion) values (@id_habitacion, @id_categoria, @num_cama, @tipo_cama, @num_baño, @num_personas, @costo, @terraza, @descripcion)", conexion);

            altas.Parameters.AddWithValue("id_habitacion", txtid_habitacion.Text);
            altas.Parameters.AddWithValue("id_categoria", txtid_categoria.Text);
            altas.Parameters.AddWithValue("num_cama", txtnum_cama.Text);
            altas.Parameters.AddWithValue("tipo_cama", txttipo_cama.Text);
            altas.Parameters.AddWithValue("num_baño", txtnum_baño.Text);
            altas.Parameters.AddWithValue("num_personas", txtnum_personas.Text);
            altas.Parameters.AddWithValue("costo", txtcosto.Text);
            altas.Parameters.AddWithValue("terraza", txtterraza.Text);
            altas.Parameters.AddWithValue("descripcion", txtdescripcion.Text);

            altas.ExecuteNonQuery();

            txtid_habitacion.Clear();
            txtid_categoria.Text = "";
            txtnum_cama.Clear();
            txttipo_cama.Clear();
            txtnum_baño.Clear();
            txtnum_personas.Clear();
            txtcosto.Clear();
            txtterraza.Clear();
            txtdescripcion.Clear();
            txtid_habitacion.Focus();

            MessageBox.Show("Habitacion dado de alta");

            conexion.Close();
        }

        private void cmdbaja_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string baja = "DELETE FROM Habitaciones WHERE id_habitacion = @id_habitacion";

            SqlCommand cmdbaja = new SqlCommand(baja, conexion);
            cmdbaja.Parameters.Add("id_habitacion", txtid_habitacion.Text);
            cmdbaja.ExecuteNonQuery();

            cmdbaja.Dispose();
            cmdbaja = null;
            txtid_habitacion.Clear();
            txtnum_cama.Clear();
            txttipo_cama.Clear();
            txtnum_baño.Clear();
            txtnum_personas.Clear();
            txtcosto.Clear();
            txtterraza.Clear();
            txtdescripcion.Clear();
            txtid_habitacion.Focus();
            conexion.Close();

            MessageBox.Show("Se dio de baja");
        }

        private void cmdmodificacion_Click(object sender, EventArgs e)
        {
            if (txtid_habitacion.Text == "" || txtid_categoria.Text == "" || txtnum_cama.Text == "" || txttipo_cama.Text == "" || txtnum_baño.Text == "" || txtnum_personas.Text == "" || txtcosto.Text == "" || txtterraza.Text == "" || txtdescripcion.Text == "")
            {
                MessageBox.Show("Llenar todos los campos");
            }
            else
            {

                conexion.Open();
                string id_habitacion = txtid_habitacion.Text;
                string id_categoria = txtid_categoria.Text;
                string num_cama = txtnum_cama.Text;
                string tipo_cama = txttipo_cama.Text;
                string num_baño = txtnum_baño.Text;
                string num_personas = txtnum_personas.Text;
                string costo = txtcosto.Text;
                string terraza = txtterraza.Text;
                string descripcion = txtdescripcion.Text;
                string cadena = "update Habitaciones set id_categoria='" + id_categoria + "', num_cama='" + num_cama + "', tipo_cama='" + tipo_cama + "', num_baño='" + num_baño + "', num_personas='" + num_personas + "', costo='" + costo + "', terraza='" + terraza + "', descripcion='" + descripcion + "' where id_habitacion=" + id_habitacion;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos de la habitacion");
                    txtid_habitacion.Clear();
                    txtnum_cama.Clear();
                    txttipo_cama.Clear();
                    txtnum_baño.Clear();
                    txtnum_personas.Clear();
                    txtcosto.Clear();
                    txtterraza.Clear();
                    txtdescripcion.Clear();
                    txtid_habitacion.Focus();

                }
                else
                    MessageBox.Show("No existe un cliente con el id ingresado");
                conexion.Close();
            }
        }

        private void cmdconsulta_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            String consulta = "select * from Habitaciones where id_habitacion=" + txtid_habitacion.Text;
            SqlCommand cmdconsulta = new SqlCommand(consulta, conexion);

            try
            {
                SqlDataReader Reade = cmdconsulta.ExecuteReader();
                Reade.Read();
                txtid_categoria.Text = Reade.GetValue(1).ToString();
                txtnum_cama.Text = Reade.GetValue(2).ToString();
                txttipo_cama.Text = Reade.GetValue(3).ToString();
                txtnum_baño.Text = Reade.GetValue(4).ToString();
                txtnum_personas.Text = Reade.GetValue(5).ToString();
                txtcosto.Text = Reade.GetValue(6).ToString();
                txtterraza.Text = Reade.GetValue(7).ToString();
                txtdescripcion.Text = Reade.GetValue(8).ToString();
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
            string sql = "select * from Habitaciones";

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

        SqlCommand cmd;
        SqlDataReader dr;
        public void Id_Categoria()
        {
            cmd = new SqlCommand("select id_categoria from Categorias", conexion);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtid_categoria.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }
    }
}
