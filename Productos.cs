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
            conexion = new MySqlConnection("server=localhost;user=root;database=tienda;port=3308");

            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("SELECT ID_PROV FROM PROVEEDOR;", conexion);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);
                ID_PROV.ValueMember = "ID_PROV";
                ID_PROV.DataSource = dt;
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex) { MessageBox.Show("Ha ocurrido un error: \n" + ex.Message); }
        }

       /* public void cargar_proveedor()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;database=tienda;port=3308");
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand($"SELECT NOMBRE FROM proveedor WHERE ID_PROV = {ID_PROV.SelectedValue}", conexion);

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion;
            conexion = new MySqlConnection("server=localhost;user=root;database=tienda;port=3308");

            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO producto values(@ID_PROD, @ID_PROV, @DESCRIPCION)", conexion);
                //MySqlCommand comando = new MySqlCommand("INSERT INTO producto values(@ID_PROD, @ID_PROV, @DESCRIPCION, @PRECIO, @STOCK_MIN, @STOCK_MAX)", conexion);
                comando.Parameters.Add("ID_PROD", MySqlDbType.VarChar).Value = ID_PROD.Text;
                comando.Parameters.Add("ID_PROV", MySqlDbType.VarChar).Value = ID_PROV.SelectedValue;
                comando.Parameters.Add("DESCRIPCION", MySqlDbType.VarChar).Value = DESCRIPCION.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n" + ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ID_PROD.Clear();
            DESCRIPCION.Clear();
        }

        private void ID_PROD_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
