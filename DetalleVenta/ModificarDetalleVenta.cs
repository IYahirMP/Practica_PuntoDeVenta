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

namespace Practica.DetalleVenta
{
    public partial class ModificarDetalleVenta : Form
    {
        string stringConn = "server=localhost;uid=root;database=tienda;port=3308";

        public void cargar_ID_DV()
        {
            MySqlConnection conn = new MySqlConnection(stringConn);
            DataSet tabla = new DataSet();
            string consulta = "SELECT ID_DV FROM detalle";

            try
            {
                MySqlDataAdapter interfaz = new MySqlDataAdapter(consulta, conn);
                interfaz.Fill(tabla, "ID_DV");
                ID_DV.ValueMember = "ID_DV";
                ID_DV.DataSource = tabla.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema al cargar la lista de identificadores de proveedor.\n"
                    + e.Message);
            }
        }

        public void cargarRegistro()
        {
            MySqlConnection conn = new MySqlConnection(stringConn);
            DataSet tabla = new DataSet();
            string consulta = $"SELECT * FROM detalle WHERE ID_DV = {ID_DV.SelectedValue}";

            try
            {
                MySqlDataAdapter daProveedor = new MySqlDataAdapter(consulta, conn);
                daProveedor.Fill(tabla, "detalle");
                ID_VENTA.Text = tabla.Tables[0].Rows[0]["ID_VENTA"].ToString();
                ID_PROD.Text = tabla.Tables[0].Rows[0]["ID_PROD"].ToString();
                CANTIDAD.Text = tabla.Tables[0].Rows[0]["CANTIDAD"].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error:\n" + e.Message);
            }
        }
        public ModificarDetalleVenta()
        {
            InitializeComponent();
            cargar_ID_DV();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            cargarRegistro();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(stringConn);
            string actualizacion = $"UPDATE detalle SET ID_PROD = {ID_PROD.Text}, ID_VENTA = {ID_VENTA.Text}, CANTIDAD = {CANTIDAD.Text} WHERE ID_DV = {ID_DV.SelectedValue}";
            MySqlCommand actualizar = new MySqlCommand(actualizacion, conn);
            try
            {
                conn.Open();
                actualizar.ExecuteNonQuery();
                MessageBox.Show($"Registro {ID_DV.SelectedValue} actualizado correctamente.");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al actualizar los datos del registro {ID_DV.SelectedValue}\n" + ex.Message);
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            ID_DV.Text = "Escoge un valor de la lista";
            ID_PROD.Text = "";
            ID_VENTA.Text = "";
            CANTIDAD.Text = "";
        }

        private void ID_DV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(stringConn);
            string consulta = $"delete from detalle where ID_DV = {ID_DV.SelectedValue}";
            MySqlCommand com = new MySqlCommand(consulta, conn);

            try
            {
                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
                cargar_ID_DV();
                MessageBox.Show("Registro eliminado con éxito.");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ha ocurido un error al eliminar el registro.\n{ex.Message}");
            }
        }
    }
}
