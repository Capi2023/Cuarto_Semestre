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
    public partial class frmCategorias : Form
    {
        SqlConnection conexion = new SqlConnection(@"server=(localdb)\clinica; Initial Catalog=Hotel; integrated security=true");

        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            conexion.Open();
            Id_Hotel();
            conexion.Close();
            CargarUnDatagrid();
        }

        private void cmdcargar_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            SqlCommand altas = new SqlCommand("insert into Categorias (id_categoria, id_hotel) values (@id_categoria, @id_hotel)", conexion);

            altas.Parameters.AddWithValue("id_categoria", txtid_categoria.Text);
            altas.Parameters.AddWithValue("id_hotel", txtid_hotel.Text);

            altas.ExecuteNonQuery();

            txtid_categoria.Clear();
            txtid_hotel.Text = "";
            txtid_categoria.Focus();

            MessageBox.Show("Categoria dado de alta");

            conexion.Close();
        }

        private void cmdbaja_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string baja = "DELETE FROM Categorias WHERE id_categoria = @id_categoria";

            SqlCommand cmdbaja = new SqlCommand(baja, conexion);
            cmdbaja.Parameters.Add("id_categoria", txtid_categoria.Text);
            cmdbaja.ExecuteNonQuery();

            cmdbaja.Dispose();
            cmdbaja = null;
            txtid_categoria.Clear();
            txtid_categoria.Focus();
            conexion.Close();

            MessageBox.Show("Se dio de baja");
        }

        private void cmdconsulta_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            String consulta = "select * from Categorias where id_categoria=" + txtid_categoria.Text;
            SqlCommand cmdconsulta = new SqlCommand(consulta, conexion);

            try
            {
                SqlDataReader Reade = cmdconsulta.ExecuteReader();
                Reade.Read();
                txtid_hotel.Text = Reade.GetValue(1).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro");

            }

            conexion.Close();
        }

        private void cmdmodificacion_Click(object sender, EventArgs e)
        {
            if (txtid_categoria.Text == "" || txtid_hotel.Text == "")
            {
                MessageBox.Show("Llenar todos los campos");
            }
            else
            {

                conexion.Open();
                string id = txtid_categoria.Text;
                string hotel = txtid_hotel.Text;
                string cadena = "update Categorias set id_hotel='" + hotel + "' where id_categoria=" + id;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del hotel");
                    txtid_categoria.Clear();
                    txtid_categoria.Focus();

                }
                else
                    MessageBox.Show("No existe un hotel con el id ingresado");
                conexion.Close();
            }
        }

        void CargarUnDatagrid()
        {

            //definir la consulta sql server
            string sql = "select * from Categorias";

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
        public void Id_Hotel()
        {
            cmd = new SqlCommand("select id_hotel from Hoteles", conexion);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtid_hotel.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }
    }
}
