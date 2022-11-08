using MySql.Data.MySqlClient;

namespace Practica
{
    public partial class DetalleVentas : Form
    {
        public DetalleVentas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion;
            conexion = new MySqlConnection("server=localhost;user=root;database=tienda;port=3308");

            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO detalle values(@ID_DV, @ID_PROD, @ID_VENTA, @CANTIDAD)", conexion);
                comando.Parameters.Add("ID_DV", MySqlDbType.VarChar).Value = ID_DV.Text;
                comando.Parameters.Add("ID_PROD", MySqlDbType.VarChar).Value = ID_PROD.Text;
                comando.Parameters.Add("ID_VENTA", MySqlDbType.VarChar).Value = ID_VENTA.Text;
                comando.Parameters.Add("CANTIDAD", MySqlDbType.Int64).Value = CANTIDAD.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error:\n" + ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ID_DV.Clear();
            ID_PROD.Clear();
            ID_VENTA.Clear();
            CANTIDAD.Clear();
        }
    }
}
