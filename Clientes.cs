using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Practica
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion;
            conexion = new MySqlConnection("server=localhost;user=root;database=tienda;port=3306");
            conexion.Open();
            //string sql = $@"INSERT INTO proveedor values ({ID_PROV.Text},/"{NOMBRE.Text}/"", {DIRECCION.Text})";
            MySqlCommand comando = new MySqlCommand("INSERT INTO cliente values(@ID_CLIENTE, @RFC, @NOMBRE)", conexion);
            comando.Parameters.Add("ID_CLIENTE", MySqlDbType.VarChar).Value = ID_CLIENTE.Text;
            comando.Parameters.Add("RFC", MySqlDbType.VarChar).Value = RFC.Text;
            comando.Parameters.Add("NOMBRE", MySqlDbType.VarChar).Value = NOMBRE.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro exitoso");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
