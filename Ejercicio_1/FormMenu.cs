using System;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnAgregarEstudiantes_Click(object sender, EventArgs e)
        {
            // Deshabilitar el botón para evitar múltiples clics
            btnAgregarEstudiantes.Enabled = false;

            // Crear una instancia del formulario FormAgregarUsuarios
            FormAgregarAlumnos formAgregarUsuarios = new FormAgregarAlumnos();

            // Suscribirse al evento FormClosed del nuevo formulario
            formAgregarUsuarios.FormClosed += FormAgregarUsuarios_FormClosed;

            // Mostrar el formulario FormAgregarUsuarios
            formAgregarUsuarios.Show();
        }

        private void FormAgregarUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnAgregarEstudiantes.Enabled = true;
        }

        private void btnListadoEstudiantes_Click(object sender, EventArgs e)
        {
            btnListadoEstudiantes.Enabled = false;

            FormListarAlumnos FormListarAlumnos = new FormListarAlumnos();

            // Suscribirse al evento FormClosed del nuevo formulario
            FormListarAlumnos.FormClosed += FormListarAlumnos_FormClosed;

            FormListarAlumnos.Show();
        }

        private void FormListarAlumnos_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnListadoEstudiantes.Enabled = true;
        }

        private void btnReporteEstudiantes_Click(object sender, EventArgs e)
        {
            btnReporteEstudiantes.Enabled = false;

            FormReporteAlumnos FormReporteAlumnos = new FormReporteAlumnos();

            // Suscribirse al evento FormClosed del nuevo formulario
            FormReporteAlumnos.FormClosed += FormReporteAlumnos_FormClosed;

            FormReporteAlumnos.Show();
        }

        private void FormReporteAlumnos_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnReporteEstudiantes.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
