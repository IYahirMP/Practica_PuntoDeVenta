using Practica.Cliente;
using Practica.Producto;
using Practica.DetalleVenta;
using Practica.Venta;

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
            DetalleVentas ventana = new DetalleVentas();
            ventana.Show();
        }

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarProveedor ventana = new ModificarProveedor();
            ventana.Show();
        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mODIFICARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificarProducto ventana = new ModificarProducto();
            ventana.Show();
        }

        private void eLIMINARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void mODIFICARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ModificarCliente ventana = new ModificarCliente();
            ventana.Show();
        }

        private void eLIMINARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void mODIFICARToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ModificarVenta ventana = new ModificarVenta();
            ventana.Show();
        }

        private void eLIMINARToolStripMenuItem3_Click(object sender, EventArgs e)
        {
        }

        private void mODIFICARToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ModificarDetalleVenta ventana = new ModificarDetalleVenta();
            ventana.Show();
        }

        private void eLIMINARToolStripMenuItem4_Click(object sender, EventArgs e)
        {
        }
    }
}