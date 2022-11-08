using MySql.Data.MySqlClient;

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
            conexion = new MySqlConnection("server=localhost;user=root;database=tienda;port=3308");

            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO venta values(@ID_VENTA, @ID_CLIENTE, @FECHA, @HORA, @TOTAL)", conexion);
                comando.Parameters.Add("ID_VENTA", MySqlDbType.VarChar).Value = ID_VENTA.Text;
                comando.Parameters.Add("ID_CLIENTE", MySqlDbType.VarChar).Value = ID_CLIENTE.Text;
                comando.Parameters.Add("FECHA", MySqlDbType.Date).Value = FECHA.Value.Date;
                comando.Parameters.Add("HORA", MySqlDbType.Time).Value = TimeOnly.Parse($"{HORA.Value.ToString()}:{MINUTO.Value.ToString()}:{SEGUNDO.Value.ToString()}");
                comando.Parameters.Add("TOTAL", MySqlDbType.Int32).Value = TOTAL.Text;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error.\n" + ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ID_VENTA.Clear();
            ID_CLIENTE.Clear();
            HORA.Value = 0;
            MINUTO.Value = 0;
            SEGUNDO.Value = 0;
            TOTAL.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
