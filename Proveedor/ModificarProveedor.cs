using MySql.Data.MySqlClient;
using System.Data;

namespace Practica
{
    public partial class ModificarProveedor : Form
    {
        string conexion = "server=localhost; uid=root; database=tienda; port=3308";

        public void cargar_ID_PROV()
        {
            MySqlConnection conn = new MySqlConnection(conexion);
            DataSet tabla = new DataSet();
            string consulta = "SELECT ID_PROV FROM proveedor";



            try
            {
                MySqlDataAdapter interfaz = new MySqlDataAdapter(consulta, conn);
                interfaz.Fill(tabla, "ID_PROV");
                ID_PROV.ValueMember = "ID_PROV";
                ID_PROV.DataSource = tabla.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema al cargar la lista de identificadores de proveedor.\n"
                    + e.Message);
            }
        }

        public void cargarRegistro()
        {
            MySqlConnection conn = new MySqlConnection(conexion);
            DataSet tabla = new DataSet();
            string consulta = $"SELECT * FROM proveedor WHERE ID_PROV = {ID_PROV.SelectedValue}";

            try
            {
                MySqlDataAdapter daProveedor = new MySqlDataAdapter(consulta, conn);
                daProveedor.Fill(tabla, "proveedor");
                NOMBRE.Text = (string)tabla.Tables[0].Rows[0]["nombre"];
                DIRECCION.Text = (string)tabla.Tables[0].Rows[0]["direccion"];
                TELEFONO.Text = (string)tabla.Tables[0].Rows[0]["telefono"];
                CORREO.Text = (string)tabla.Tables[0].Rows[0]["correo"];
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error:\n" + e.Message);
            }
        }
        public ModificarProveedor()
        {
            InitializeComponent();
            cargar_ID_PROV();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cargarRegistro();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conexion);
            string actualizacion = $"UPDATE proveedor SET NOMBRE =\"{NOMBRE.Text}\", DIRECCION = \"{DIRECCION.Text}\", TELEFONO = \"{TELEFONO.Text}\", CORREO = \"{CORREO.Text}\" WHERE ID_PROV = {ID_PROV.SelectedValue}";
            MySqlCommand actualizar = new MySqlCommand(actualizacion, conn);
            try
            {
                conn.Open();
                actualizar.ExecuteNonQuery();
                MessageBox.Show($"Registro {ID_PROV.SelectedValue} actualizado correctamente.");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al actualizar los datos del registro {ID_PROV.SelectedValue}\n" + ex.Message);
            }
        }

        public void limpiar()
        {
            ID_PROV.ResetText();
            NOMBRE.Text = "";
            DIRECCION.Text = "";
            TELEFONO.Text = "";
            CORREO.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conexion);
            string consulta = $"delete from proveedor where ID_PROV = {ID_PROV.SelectedValue}";
            MySqlCommand com = new MySqlCommand(consulta, conn);

            try
            {
                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();

                cargar_ID_PROV();
                limpiar();
                MessageBox.Show("El registro ha sido eliminado con éxito.");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al eliminar el registro. {ex.Message}");
            }
        }
    }
}
