using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Productos : Form
    {
        string conn = "server=localhost;user=root;database=tienda;port=3308";
        public Productos()
        {
            InitializeComponent();
            cargarComboBox();
        }

        public void cargarComboBox()
        {
            ID_PROV.DataSource = null;
            ID_PROV.Items.Clear();

            MySqlConnection conexion;
            conexion = new MySqlConnection(conn);

            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("SELECT NOMBRE FROM PROVEEDOR;", conexion);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);
                comando.ExecuteNonQuery();
                ID_PROV.ValueMember = "NOMBRE";
                ID_PROV.DataSource = dt;
            }
            catch (MySqlException ex) { MessageBox.Show("Ha ocurrido un error: \n" + ex.Message); }
        }

        public int obtenerIDProv() {
            MySqlConnection conexion = new MySqlConnection(conn);
            string sql = $"SELECT ID_PROV FROM proveedor WHERE nombre = \"{ID_PROV.SelectedValue}\"";
            MySqlCommand consulta = new MySqlCommand(sql, conexion);
            Object resultado = null;
            try
            {
                conexion.Open();
                resultado = consulta.ExecuteScalar();
            } catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un error al obtener el ID del proveedor."
                    + "\nError:\n" + e.Message);
            }
            
            int idProv = 0;
            if (resultado != null)
                idProv = (int)resultado;

            return idProv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion;
            conexion = new MySqlConnection(conn);

            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO producto values(@ID_PROD, @ID_PROV, @DESCRIPCION, @PRECIO, @STOCKMax, @STOCKMin)", conexion);
                comando.Parameters.Add("ID_PROD", MySqlDbType.VarChar).Value = ID_PROD.Text;
                comando.Parameters.Add("ID_PROV", MySqlDbType.VarChar).Value = obtenerIDProv();
                comando.Parameters.Add("DESCRIPCION", MySqlDbType.VarChar).Value = DESCRIPCION.Text;
                comando.Parameters.Add("PRECIO", MySqlDbType.Int32).Value = Precio.Text;
                comando.Parameters.Add("STOCKMax", MySqlDbType.Int32).Value = StockMaximo.Text;
                comando.Parameters.Add("STOCKMin", MySqlDbType.Int32).Value = StockMinimo.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n" + ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ID_PROD.Clear();
            DESCRIPCION.Clear();
            ID_PROV.ResetText();
        }

        private void ID_PROD_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
