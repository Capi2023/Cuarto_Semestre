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
    public partial class frmdoctor_responsable : Form
    {
        public frmdoctor_responsable()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"server=(localdb)\clinica; Initial Catalog=clinica; integrated security=true");

        private void frmdoctor_responsable_Load(object sender, EventArgs e)
        {
            conexion.Open();

            BindDatanumero();
            conexion.Close();
            CargarUnDatagrid();
        }

        SqlCommand cmd;
        SqlDataReader dr;

        public void BindDatanumero()
        {
            cmd = new SqlCommand("select num_unidad from unidad", conexion);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                combonum_unidad.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        void CargarUnDatagrid()
        {

            //definir la consulta sql server
            string sql = "select * from doctor_responsable";

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

        private void cmdregresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Subida_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            SqlCommand altas = new SqlCommand("insert into doctor_responsable (id_doctor, nombre_doctor, especialidad, num_unidad) values (@id_doctor, @nombre_doctor, @especialidad, @num_unidad)", conexion);

            altas.Parameters.AddWithValue("id_doctor", txtid_doctor.Text);
            altas.Parameters.AddWithValue("nombre_doctor", txtnombre_doctor.Text);
            altas.Parameters.AddWithValue("especialidad", txtespecialidad.Text);
            altas.Parameters.AddWithValue("num_unidad", combonum_unidad.Text);

            altas.ExecuteNonQuery();

            txtid_doctor.Text = "";
            txtnombre_doctor.Text = "";
            txtespecialidad.Text = "";
            combonum_unidad.Text = "";

            MessageBox.Show("Doctor dado de alta");

            conexion.Close();
        }

        private void baja_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string baja = "DELETE FROM doctor_responsable WHERE id_doctor = @id_doctor";

            SqlCommand cmdbaja = new SqlCommand(baja, conexion);
            cmdbaja.Parameters.Add("id_doctor", txtid_doctor.Text);
            cmdbaja.ExecuteNonQuery();

            cmdbaja.Dispose();
            cmdbaja = null;
            txtid_doctor.Clear();
            txtnombre_doctor.Clear();
            txtespecialidad.Clear();
            txtid_doctor.Focus();
            conexion.Close();

            MessageBox.Show("Se doy de baja");
        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            String consulta = "select * from doctor_responsable where id_doctor=" + txtid_doctor.Text;
            SqlCommand cmdconsulta = new SqlCommand(consulta, conexion);

            try
            {
                SqlDataReader Reade = cmdconsulta.ExecuteReader();
                Reade.Read();
                txtnombre_doctor.Text = Reade.GetValue(1).ToString();
                txtespecialidad.Text = Reade.GetValue(2).ToString();
                combonum_unidad.Text = Reade.GetValue(3).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro");

            }

            conexion.Close();
        }

        private void modificacion_Click(object sender, EventArgs e)
        {
            if (txtid_doctor.Text == "" || txtnombre_doctor.Text == "" || txtespecialidad.Text == "" || combonum_unidad.Text == "")
            {
                MessageBox.Show("Llenar todos los campos");
            }
            else
            {
                conexion.Open();
                string id = txtid_doctor.Text;
                string nombre = txtnombre_doctor.Text;
                string especialidad = txtespecialidad.Text;
                string num_unidad = combonum_unidad.Text;
                string cadena = "update doctor_responsable set nombre_doctor='" + nombre + "', especialidad='" + especialidad + "', num_unidad='" + num_unidad + "' where id_doctor=" + id;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del doctor");
                    txtid_doctor.Clear();
                    txtnombre_doctor.Clear();
                    txtespecialidad.Clear();
                    txtid_doctor.Focus();
                }
                else
                    MessageBox.Show("No existe un doctor con el id ingresado");
                conexion.Close();
            }
        }
    }
}
