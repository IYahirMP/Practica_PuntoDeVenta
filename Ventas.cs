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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion;
            conexion = new MySqlConnection("server=localhost;user=root;database=tienda;port=3306");

            try { 
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("INSERT INTO venta values(@ID_VENTA, @ID_CLIENTE, @FECHA)", conexion);
            comando.Parameters.Add("ID_VENTA", MySqlDbType.VarChar).Value = ID_VENTA.Text;
            comando.Parameters.Add("ID_CLIENTE", MySqlDbType.VarChar).Value = ID_CLIENTE.Text;
            comando.Parameters.Add("FECHA", MySqlDbType.Timestamp).Value = DateTime.Now;
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro exitoso");
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error.\n" + ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ID_VENTA.Clear();
            ID_CLIENTE.Clear();
            FECHA.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
