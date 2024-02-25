using Ejercicio_1.Models;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class FormListarAlumnos : Form
    {
        public FormListarAlumnos()
        {
            InitializeComponent();

            LlenarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            // Limpiar las columnas existentes
            listarAlumnosGrid.Columns.Clear();

            // Agregar columnas para las propiedades de Alumno
            listarAlumnosGrid.Columns.Add("numero", "Numero");
            listarAlumnosGrid.Columns.Add("carnet", "Carnet");
            listarAlumnosGrid.Columns.Add("nombre", "Nombre");
            listarAlumnosGrid.Columns.Add("apellido", "Apellido");

            // Impedir a los usuarios agregar nuevas filas
            listarAlumnosGrid.AllowUserToAddRows = false;

            // Impedir a los usuarios editar las celdas
            listarAlumnosGrid.ReadOnly = true;

            // Otras configuraciones para evitar la edición:
            // Impedir a los usuarios eliminar filas
            listarAlumnosGrid.AllowUserToDeleteRows = false;

            // Impedir a los usuarios ordenar las columnas
            listarAlumnosGrid.AllowUserToOrderColumns = false;

            // Impedir el ajuste de tamaño de las columnas y filas por parte del usuario
            listarAlumnosGrid.AllowUserToResizeColumns = false;
            listarAlumnosGrid.AllowUserToResizeRows = false;
        }

        private void LlenarDataGridView()
        {
            // Asegúrate de que el DataGridView esté configurado
            ConfigurarDataGridView();

            // Obtener los alumnos
            Alumno[] alumnos = AppContext.ObtenerAlumnos();

            // Limpiar filas existentes
            listarAlumnosGrid.Rows.Clear();

            // Llenar el DataGridView con los datos de los alumnos
            foreach (var (alumno, index) in alumnos.Select((a, index) => ( a, index)))
                listarAlumnosGrid.Rows.Add(index+1, alumno.Carnet, alumno.Nombre, alumno.Apellido, alumno.Materia);
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
