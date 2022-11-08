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

namespace Practica.Producto
{
    public partial class ModificarProducto : Form
    {
        string conn = "server = localhost; port = 3308; uid = root; database= tienda";
        public void cargarComboBox()
        {
            MySqlConnection conexion;
            conexion = new MySqlConnection(conn);
            DataSet a = new DataSet();
            string consultaProv = "select ID_PROV, NOMBRE from proveedor";
            string consultaProd = "select ID_PROD, DESCRIPCION from producto";
            MySqlDataAdapter b = new MySqlDataAdapter(consultaProv, conexion);
            MySqlDataAdapter c = new MySqlDataAdapter(consultaProd, conexion);

            try {
                b.Fill(a, "proveedor");
                c.Fill(a, "producto");
                ID_PROV.DataSource = a.Tables["proveedor"];
                ID_PROV.DisplayMember = "NOMBRE";
                ID_PROV.ValueMember = "ID_PROV";
                ID_PROD.DataSource = a.Tables["producto"];
                ID_PROD.DisplayMember = "NOMBRE";
                ID_PROD.ValueMember = "ID_PROD";
            }
            catch (MySqlException ex) { MessageBox.Show("Ha ocurrido un error: \n" + ex.Message); }
        }

        public ModificarProducto()
        {
            InitializeComponent();
            cargarComboBox();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(conn);
            DataTable a = new DataTable();
            string consulta = $"SELECT * FROM producto WHERE ID_PROD = {ID_PROD.SelectedValue}";
            MySqlDataAdapter b = new MySqlDataAdapter(consulta, conexion);

            try
            {
                b.Fill(a);
                ID_PROV.SelectedValue = a.Rows[0]["ID_PROV"];
                DESCRIPCION.Text = (string)a.Rows[0]["DESCRIPCION"];
                Precio.Text = a.Rows[0]["PRECIO"].ToString();
                StockMaximo.Text = a.Rows[0]["STOCK MAXIMO"].ToString();
                StockMinimo.Text = a.Rows[0]["STOCK MINIMO"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al cargar los datos del registro.\n{ex.Message}");
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(conn);
            string consulta = $"UPDATE producto SET ID_PROV = {ID_PROV.SelectedValue}, DESCRIPCION = '{DESCRIPCION.Text}', PRECIO = {Precio.Text}, `STOCK MAXIMO` = {StockMaximo.Text}, `STOCK MINIMO` = {StockMinimo.Text} WHERE ID_PROD = {ID_PROD.SelectedValue}";
            MySqlCommand com = new MySqlCommand(consulta, conexion);

            try
            {
                conexion.Open();
                com.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Registro actualizado con éxito.");
            }
            catch (Exception ex){
                MessageBox.Show($"Ha ocurrido un error al actualizar el registro.\n{ex.Message}");
            }
        }

        public void limpiar()
        {
            ID_PROD.ResetText();
            DESCRIPCION.Clear();
            ID_PROV.ResetText();
            Precio.Text = "";
            StockMaximo.Text = "";
            StockMinimo.Text = "";
        }
        private void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(conn);
            string consulta = $"DELETE FROM producto WHERE ID_PROD = {ID_PROD.SelectedValue}";
            MySqlCommand com = new MySqlCommand(consulta, conexion);

            try
            {
                conexion.Open();
                com.ExecuteNonQuery();
                conexion.Close();
                cargarComboBox();
                limpiar();
                MessageBox.Show("El registro ha sido eliminado con éxito.");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al eliminar el registro.\n{ex.Message}");
            }
        }
    }
}
