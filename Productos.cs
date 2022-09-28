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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion;
            conexion = new MySqlConnection("server=localhost;user=root;database=tienda;port=3306");
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("INSERT INTO producto values(@ID_PROD, @ID_PROV, @DESCRIPCION)", conexion);
            comando.Parameters.Add("ID_PROD", MySqlDbType.VarChar).Value = ID_PROD.Text;
            comando.Parameters.Add("ID_PROV", MySqlDbType.VarChar).Value = ID_PROV.Text;
            comando.Parameters.Add("DESCRIPCION", MySqlDbType.VarChar).Value = DESCRIPCION.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro exitoso");
        }
    }
}
