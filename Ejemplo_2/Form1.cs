using Ejemplo_2.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejemplo_2
{
    public partial class Form1 : Form
    {
        private List<Producto> Productos = new List<Producto>();
        private int edit_indice = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void actualizarGrid()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Productos; 
        }
        private void reseteo()
        {
            tbxNombre.Clear();
            tbxDescripcion.Clear();
            tbxMarca.Clear();
            tbxPrecio.Clear();
            tbxStock.Clear();
        }

        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvProductos.SelectedRows[0];
            int posicion = dgvProductos.Rows.IndexOf(selected);
            edit_indice = posicion;
            Producto product = Productos[posicion];
            tbxNombre.Text = product.Nombre;
            tbxDescripcion.Text = product.Descripcion;
            tbxMarca.Text = product.Marca;
            tbxPrecio.Text = Convert.ToString(product.Precio);
            tbxStock.Text = Convert.ToString(product.Stock);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            float.TryParse(tbxPrecio.Text, out float precio);
            int.TryParse(tbxStock.Text, out int stock);

            Producto product = new Producto();
            product.Nombre = tbxNombre.Text;
            product.Descripcion = tbxDescripcion.Text;
            product.Marca = tbxMarca.Text;
            product.Precio = precio;
            product.Stock = stock;

            if (edit_indice > -1)
            {
                Productos[edit_indice] = product;
                edit_indice = -1;
            }
            else
            {
                Productos.Add(product); 
            }

            actualizarGrid();
            reseteo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1)
            {
                Productos.RemoveAt(edit_indice);
                edit_indice = -1;
                reseteo();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Dar doble click sobre elemento para seleccionar y borrar ");
            }
        }
    }
}
