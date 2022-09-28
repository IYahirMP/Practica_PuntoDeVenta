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
        //cadena de conexion
        //"server = <servidor>; user id = <usuario>; password = <contraseña>; database = <nombre de la base de datos>;"
        private MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;database=tienda;port=3306");

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
            conexion = new MySqlConnection("server=localhost;user=root;database=tienda;port=3306");
            conexion.Open();
            //string sql = $@"INSERT INTO proveedor values ({ID_PROV.Text},/"{NOMBRE.Text}/"", {DIRECCION.Text})";
            MySqlCommand comando = new MySqlCommand("INSERT INTO proveedor values(@ID_PROV, @NOMBRE, @DIR, @TEl, @CORREO)", conexion);
            comando.Parameters.Add("ID_PROV",MySqlDbType.VarChar).Value = ID_PROV.Text;
            comando.Parameters.Add("NOMBRE", MySqlDbType.VarChar).Value = NOMBRE.Text;
            comando.Parameters.Add("DIR", MySqlDbType.VarChar).Value = DIRECCION.Text;
            comando.Parameters.Add("TEL", MySqlDbType.VarChar).Value = TELEFONO.Text;
            comando.Parameters.Add("CORREO", MySqlDbType.VarChar).Value = CORREO.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro exitoso");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
