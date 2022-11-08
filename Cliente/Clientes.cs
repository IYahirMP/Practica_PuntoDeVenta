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
            conexion = new MySqlConnection("server=localhost;user=root;database=tienda;port=3308");

            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO cliente values(@ID_CLIENTE, @RFC, @NOMBRE)", conexion);
                comando.Parameters.Add("ID_CLIENTE", MySqlDbType.VarChar).Value = ID_CLIENTE.Text;
                comando.Parameters.Add("RFC", MySqlDbType.VarChar).Value = RFC.Text;
                comando.Parameters.Add("NOMBRE", MySqlDbType.VarChar).Value = NOMBRE.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ID_CLIENTE.Clear();
            RFC.Clear();
            NOMBRE.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
