namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void respaldarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEGISTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores objeto1 = new Proveedores();
            objeto1.Show();
        }

        private void rEGISTRARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Productos ventana = new Productos();
            ventana.Show();
        }

        private void rEGISTRARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clientes ventana = new Clientes();
            ventana.Show();
        }

        private void rEGISTRARToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Ventas ventana = new Ventas();
            ventana.Show();
        }

        private void rEGISTRARToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DetalleVenta ventana = new DetalleVenta();
            ventana.Show();
        }

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarProveedor ventana = new ModificarProveedor();
            ventana.Show();
        }
    }
}