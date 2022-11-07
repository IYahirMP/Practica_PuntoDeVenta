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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;database=tienda;port=3308");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO proveedor values(@ID_PROV, @NOMBRE, @DIR, @TEl, @CORREO)", conexion);
                comando.Parameters.Add("ID_PROV", MySqlDbType.VarChar).Value = ID_PROV.Text;
                comando.Parameters.Add("NOMBRE", MySqlDbType.VarChar).Value = NOMBRE.Text;
                comando.Parameters.Add("DIR", MySqlDbType.VarChar).Value = DIRECCION.Text;
                comando.Parameters.Add("TEL", MySqlDbType.VarChar).Value = TELEFONO.Text;
                comando.Parameters.Add("CORREO", MySqlDbType.VarChar).Value = CORREO.Text;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ID_PROV.Clear();
            NOMBRE.Clear();
            DIRECCION.Clear();
            TELEFONO.Clear();
            CORREO.Clear();
        }

        private void DIRECCION_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
