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
    public partial class frmempleados : Form
    {
        public frmempleados()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"server=(localdb)\clinica; Initial Catalog=clinica; integrated security=true");

        private void cmdregresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        SqlCommand cmd;
        SqlDataReader dr;

        private void frmempleados_Load(object sender, EventArgs e)
        {
            conexion.Open();

            BindDatanum_unidad();
            BindDataid_doctor();
            conexion.Close();
            CargarUnDatagrid();
        }

        void CargarUnDatagrid()
        {
            //definir la consulta sql server
            string sql = "select * from empleados";

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

        public void BindDatanum_unidad()
        {
            cmd = new SqlCommand("select num_unidad from unidad", conexion);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                combonum_unidad.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        public void BindDataid_doctor()
        {
            cmd = new SqlCommand("select id_doctor from doctor_responsable", conexion);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboid_doctor.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void Subida_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            SqlCommand altas = new SqlCommand("insert into empleados (id_empleado, nombre_empleado, num_unidad, id_doctor) values (@id_empleado, @nombre_empleado, @num_unidad, @id_doctor)", conexion);

            altas.Parameters.AddWithValue("id_empleado", txtid_empleado.Text);
            altas.Parameters.AddWithValue("nombre_empleado", txtnombre_empleado.Text);
            altas.Parameters.AddWithValue("num_unidad", combonum_unidad.Text);
            altas.Parameters.AddWithValue("id_doctor", comboid_doctor.Text);

            altas.ExecuteNonQuery();

            txtid_empleado.Text = "";
            txtnombre_empleado.Text = "";

            MessageBox.Show("Empleado dado de alta");

            conexion.Close();
        }

        private void baja_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string baja = "DELETE FROM empleados WHERE id_empleado = @id_empleado";

            SqlCommand cmdbaja = new SqlCommand(baja, conexion);
            cmdbaja.Parameters.Add("id_empleado", txtid_empleado.Text);
            cmdbaja.ExecuteNonQuery();

            cmdbaja.Dispose();
            cmdbaja = null;
            txtid_empleado.Clear();
            txtnombre_empleado.Clear();
            txtid_empleado.Focus();
            conexion.Close();

            MessageBox.Show("Se doy de baja");
        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            //Se abre la conexion
            conexion.Open();
            //Se pasan los valores de los texr vos a las variables temporales
            String consulta = "select * from empleados where id_empleado=" + txtid_empleado.Text;
            SqlCommand cmdconsulta = new SqlCommand(consulta, conexion);

            try
            {
                SqlDataReader Reade = cmdconsulta.ExecuteReader();
                Reade.Read();
                txtnombre_empleado.Text = Reade.GetValue(1).ToString();
                combonum_unidad.Text = Reade.GetValue(2).ToString();
                comboid_doctor.Text = Reade.GetValue(3).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro");

            }

            conexion.Close();
        }

        private void modificacion_Click(object sender, EventArgs e)
        {
            if (txtid_empleado.Text == "" || txtnombre_empleado.Text == "" || combonum_unidad.Text == "" || comboid_doctor.Text == "")
            {
                MessageBox.Show("Llenar todos los campos");
            }
            else
            {
                conexion.Open();
                string id = txtid_empleado.Text;
                string nombre = txtnombre_empleado.Text;
                string num_unidad = combonum_unidad.Text;
                string id_doctor = comboid_doctor.Text;
                string cadena = "update empleado set nombre_empleado='" + nombre + "', num_unidad='" + num_unidad + "', id_doctor='" + id_doctor + "' where id_empleado=" + id;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del paciente");
                    txtid_empleado.Clear();
                    txtnombre_empleado.Clear();
                    txtid_empleado.Focus();
                    txtid_empleado.Focus();

                }
                else
                    MessageBox.Show("No existe un paciente con el id ingresado");
                conexion.Close();
            }
        }
    }
}
