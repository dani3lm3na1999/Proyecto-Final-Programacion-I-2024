using CapaModelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaApp.Productos
{
    public partial class AgregarProducto : Form
    {
        // Constructor
        // Debemos cargar los parámetros necesarios en nuestro formulario
        // 1. Categorias, 2. Marcas, 3. Proveedores
        public AgregarProducto()
        {
            InitializeComponent();
            CargarCategorias();
            CargarProveedores();
        }

        public class ProveedorItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
        }


        private void CargarProveedores()
        {
            cbxProveedores.DataSource = null;

            // Crear una lista de items para el ComboBox
            var proveedores = Enum.GetValues(typeof(Proveedores))
                                     .Cast<Proveedores>()
                                     .Select(p => new ProveedorItem
                                     {
                                         Text = p.ToString().Replace('_', ' '),
                                         Value = (int)p
                                     })
                                     .ToList();

            // Configurar DisplayMember y ValueMember
            cbxProveedores.DisplayMember = "Text";
            cbxProveedores.ValueMember = "Value";

            // Asignar la lista de items al ComboBox
            cbxProveedores.DataSource = proveedores;

        }

        private void CargarCategorias()
        {
            
        }
    }
}
