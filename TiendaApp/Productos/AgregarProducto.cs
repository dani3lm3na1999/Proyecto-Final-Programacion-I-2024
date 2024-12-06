using CapaLogica;
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
        // Agregar referencias a nuestra capa logica
        private ProductoBLL _prdBLL;
        private CategoriaBLL _ctgBLL;
        private MarcaBLL _mrcBLL;

        // Constructor
        // Debemos cargar los parámetros necesarios en nuestro formulario
        // 1. Categorias, 2. Marcas, 3. Proveedores
        public AgregarProducto()
        {
            InitializeComponent();
            CargarProductos();
            CargarCategorias();
            CargarProveedores();
        }

        private void CargarProductos()
        {
            _prdBLL = new ProductoBLL();
            productoBindingSource.DataSource = _prdBLL.ObtenerTodo();
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
            _ctgBLL = new CategoriaBLL();

            categoriaBindingSource.DataSource = _ctgBLL.ObtenerTodo();

            if (cbxCategoria.SelectedIndex != -1)
            {
                categoriaBindingSource.Position = cbxCategoria.SelectedIndex;
                CargarMarcas();
            }
        }

        private void CargarMarcas()
        {
            _mrcBLL = new MarcaBLL();

            Categoria categoria = (Categoria)categoriaBindingSource.Current;

            marcaBindingSource.DataSource = _mrcBLL.ObtenerPorCategoria(categoria.CategoriaId);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            productoBindingSource.MoveLast();
            productoBindingSource.AddNew();
            grbProducto.Enabled = true;
            pnlBotones.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _prdBLL = new ProductoBLL();

            productoBindingSource.EndEdit();

            Producto producto = (Producto)productoBindingSource.Current;
            producto.Proveedor = (Proveedores)cbxProveedores.SelectedValue;

            int resultado = _prdBLL.Guardar(producto);

            if (resultado > 0)
            {
                MessageBox.Show("Producto agregado con exito");
            }
            else
            {
                MessageBox.Show("No se logro agregar el producto");
            }


            grbProducto.Enabled = false;
            pnlBotones.Enabled = true;
            CargarProductos();
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategoria.SelectedIndex != -1)
            {
                categoriaBindingSource.Position = cbxCategoria.SelectedIndex;
                CargarMarcas();
            }
        }
    }
}
