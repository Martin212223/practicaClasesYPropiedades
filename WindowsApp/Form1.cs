using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.Nombre = "Remera";
            producto.Descripcion = "Remera manga corta color rojo talle M.";
            producto.PrecioCosto = 1500.50m;
            producto.Margen = 0.30;
            producto.IVA = 0.21;
            producto.Proveedor = "Supreme";
            producto.Categoria = "Ropa";
            producto.SubCategoria = "Remeras";

            MessageBox.Show("Nombre: " + producto.Nombre + "\nDescripción: " + producto.Descripcion + "\nPrecio Costo: $" + producto.PrecioCosto.ToString() + "\nMargen de ganancia: " + (producto.Margen * 100).ToString() + "%\nIVA: " + (producto.IVA * 100).ToString() + "%\nPrecio Bruto: $" + producto.PrecioBruto.ToString() + "\nPrecio Venta: $" + Math.Round(producto.PrecioVenta, 2).ToString() + "\nProveedor: " + producto.Proveedor + "\nCategoría: " + producto.Categoria + "\nSub Categoría: " + producto.SubCategoria);
        }

        private void btnCrearClienteInd_Click(object sender, EventArgs e)
        {
            ClienteIndividuo clienteIndividuo = new ClienteIndividuo();

            clienteIndividuo.Nombre = "Juan";
            clienteIndividuo.Apellido = "Perez";
            clienteIndividuo.CUIT = "123456";
            clienteIndividuo.Email = "jPerez68@email.com";
            clienteIndividuo.Telefono = "2615123456";
            clienteIndividuo.Direccion = "Calle Alguna 123, Capital, Mendoza";

            MessageBox.Show("Nombre: " + clienteIndividuo.Nombre + "\nApellido: " + clienteIndividuo.Apellido + "\nCUIT: " + clienteIndividuo.CUIT + "\nEmail: " + clienteIndividuo.Email + "\nTeléfono: " + clienteIndividuo.Telefono + "\nDirección: " + clienteIndividuo.Direccion);
        }
    }
}
