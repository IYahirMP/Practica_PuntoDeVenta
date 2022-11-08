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

namespace Practica.Cliente
{
    public partial class ModificarCliente : Form
    {

        string connString = "server=localhost; database = tienda; port=3308; uid = root";

        public void cargar_ID_Cliente()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataSet tabla = new DataSet();
            string consulta = "SELECT ID_CLIENTE FROM cliente";

            try
            {
                MySqlDataAdapter interfaz = new MySqlDataAdapter(consulta, conn);
                interfaz.Fill(tabla, "ID_CLIENTE");
                ID_CLIENTE.ValueMember = "ID_CLIENTE";
                ID_CLIENTE.DataSource = tabla.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema al cargar la lista de identificadores de proveedor.\n"
                    + e.Message);
            }
        }

        public ModificarCliente()
        {
            InitializeComponent();
            cargar_ID_Cliente();
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataSet tabla = new DataSet();
            string consulta = $"SELECT * FROM cliente WHERE ID_CLIENTE = {ID_CLIENTE.SelectedValue}";

            try
            {
                MySqlDataAdapter daProveedor = new MySqlDataAdapter(consulta, conn);
                daProveedor.Fill(tabla, "cliente");
                NOMBRE.Text = (string)tabla.Tables[0].Rows[0]["NOMBRE"];
                RFC.Text = (string)tabla.Tables[0].Rows[0]["RFC"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al buscar el registro:\n" + ex.Message);
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            string consulta = $"UPDATE cliente SET NOMBRE = '{NOMBRE.Text}', RFC = '{RFC.Text}' WHERE ID_CLIENTE = {ID_CLIENTE.SelectedValue}";
            MySqlCommand com = new MySqlCommand(consulta, conn);

            try
            {
                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("El registro se ha modificado exitosamente.");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"ha ocurrido un error durante la modificación del registro.\n´{ex.Message}");
            }
        }

        public void limpiar()
        {
            ID_CLIENTE.ResetText();
            NOMBRE.Text = "";
            RFC.Text = "";
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            string consulta = $"delete from cliente where ID_CLIENTE = {ID_CLIENTE.SelectedValue}";
            MySqlCommand com = new MySqlCommand(consulta, conn);

            try
            {
                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
                limpiar();
                cargar_ID_Cliente();
                MessageBox.Show("El registro ha sido eliminado con éxito.");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al eliminar el registro.\n{ex.Message}");
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
