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
    public partial class frmReservaciones : Form
    {
        SqlConnection conexion = new SqlConnection(@"server=(localdb)\clinica; Initial Catalog=Hotel; integrated security=true");
        public frmReservaciones()
        {
            InitializeComponent();
        }

        private void frmReservaciones_Load(object sender, EventArgs e)
        {
            conexion.Open();
            Id_Habitacion();
            Id_Cliente();
            conexion.Close();
            CargarUnDatagrid();
        }

        private void cmdcargar_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            SqlCommand altas = new SqlCommand("insert into Reservaciones (id_reservacion, id_habitacion, id_cliente, fecha_entrada, fecha_salida, num_adultos, num_niños) values (@id_reservacion, @id_habitacion, @id_cliente, @fecha_entrada, @fecha_salida, @num_adultos, @num_niños)", conexion);

            altas.Parameters.AddWithValue("id_reservacion", txtid_reservacion.Text);
            altas.Parameters.AddWithValue("id_habitacion", txtid_habitacion.Text);
            altas.Parameters.AddWithValue("id_cliente", txtid_cliente.Text);
            altas.Parameters.AddWithValue("fecha_entrada", txtfecha_entrada.Value);
            altas.Parameters.AddWithValue("fecha_salida", txtfecha_salida.Value);
            altas.Parameters.AddWithValue("num_adultos", txtnum_adultos.Text);
            altas.Parameters.AddWithValue("num_niños", txtnum_niños.Text);

            altas.ExecuteNonQuery();

            txtid_reservacion.Clear();
            txtid_habitacion.Text = "";
            txtid_cliente.Text = "";
            txtfecha_entrada.Text = "";
            txtfecha_salida.Text = "";
            txtnum_adultos.Clear();
            txtnum_niños.Clear();
            txtid_reservacion.Focus();

            MessageBox.Show("Reservacion dado de alta");

            conexion.Close();
        }

        private void cmdbaja_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string baja = "DELETE FROM Reservaciones WHERE id_reservacion = @id_reservacion";

            SqlCommand cmdbaja = new SqlCommand(baja, conexion);
            cmdbaja.Parameters.Add("id_reservacion", txtid_reservacion.Text);
            cmdbaja.ExecuteNonQuery();

            cmdbaja.Dispose();
            cmdbaja = null;
            txtid_reservacion.Clear();
            txtid_habitacion.Text = "";
            txtid_cliente.Text = "";
            txtfecha_entrada.Text = "";
            txtfecha_salida.Text = "";
            txtnum_adultos.Clear();
            txtnum_niños.Clear();
            txtid_reservacion.Focus();
            conexion.Close();

            MessageBox.Show("Se dio de baja");
        }

        private void cmdconsulta_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            String consulta = "select * from Reservaciones where id_reservacion=" + txtid_reservacion.Text;
            SqlCommand cmdconsulta = new SqlCommand(consulta, conexion);

            try
            {
                SqlDataReader Reade = cmdconsulta.ExecuteReader();
                Reade.Read();
                txtid_habitacion.Text = Reade.GetValue(1).ToString();
                txtid_cliente.Text = Reade.GetValue(2).ToString();
                txtfecha_entrada.Text = Reade.GetValue(3).ToString();
                txtfecha_salida.Text = Reade.GetValue(4).ToString();
                txtnum_adultos.Text = Reade.GetValue(5).ToString();
                txtnum_niños.Text = Reade.GetValue(6).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro");

            }

            conexion.Close();
        }

        private void cmdmodificacion_Click(object sender, EventArgs e)
        {
            if (txtid_reservacion.Text == "" || txtid_habitacion.Text == "" || txtid_cliente.Text == "" || txtfecha_entrada.Text == "" || txtfecha_salida.Text == "" || txtnum_adultos.Text == "" || txtnum_niños.Text == "")
            {
                MessageBox.Show("Llenar todos los campos");
            }
            else
            {

                conexion.Open();
                string id_reservacion = txtid_reservacion.Text;
                string id_habitacion = txtid_habitacion.Text;
                string id_cliente = txtid_cliente.Text;
                string fecha_entrada = txtfecha_entrada.Text;
                string fecha_salida = txtfecha_salida.Text;
                string num_adultos = txtnum_adultos.Text;
                string num_niños = txtnum_niños.Text;
                string cadena = "update Reservaciones set id_habitacion='" + id_habitacion + "', id_cliente='" + id_cliente + "', fecha_entrada='" + fecha_entrada + "', fecha_salida='" + fecha_salida + "', num_adultos='" + num_adultos + "', num_niños='" + num_niños + "' where id_reservacion=" + id_reservacion;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos de la reservacion");
                    txtid_reservacion.Clear();
                    txtnum_adultos.Clear();
                    txtnum_niños.Clear();
                    txtid_reservacion.Focus();

                }
                else
                    MessageBox.Show("No existe un cliente con el id ingresado");
                conexion.Close();
            }
        }

        void CargarUnDatagrid()
        {

            //definir la consulta sql server
            string sql = "select * from Reservaciones";

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
        public void Id_Habitacion()
        {
            cmd = new SqlCommand("select id_habitacion from Habitaciones", conexion);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtid_habitacion.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        public void Id_Cliente()
        {
            cmd = new SqlCommand("select id_cliente from Clientes", conexion);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtid_cliente.Items.Add(dr[0].ToString());            }            dr.Close();        }}}
