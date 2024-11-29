using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaApp.Productos;

namespace TiendaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Muestre la ventana AgregarProductos
            AgregarProducto objProducto = new AgregarProducto();
            objProducto.ShowDialog();
        }
    }
}
