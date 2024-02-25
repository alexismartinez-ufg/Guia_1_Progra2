using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejemplo_1
{
    public partial class FrmRecibe : Form
    {
        public List<Persona> PersonaRecibe = null; //creación de una lista que reciba
        public FrmRecibe()
        {
            InitializeComponent();
        }
        private void actualizarGrid() //función que llena el DGV del formulario 2
        {
            dgvRecibe.DataSource = null;
            dgvRecibe.DataSource = PersonaRecibe;
        }

        private void btnLlenar_Click_1(object sender, EventArgs e)
        {
            actualizarGrid();
        }
    }
}
