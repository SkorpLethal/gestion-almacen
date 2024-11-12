using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlmacen
{
    public partial class FormPrincipal : Form
    {
        private List<Producto> Productos { get; set; }
        public FormPrincipal()
        {
            Productos = new List<Producto>();
            var producto1 = new Producto("estanteria", 5, 20.5);
            Productos.Add(producto1);
            InitializeComponent();
            actualizarInventario();
        }
        private void actualizarInventario()
        {
            dtProductos.DataSource = null;
            dtProductos.DataSource = Productos;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormProducto formProducto = new FormProducto();
            formProducto.ShowDialog();
        }
    }
}
