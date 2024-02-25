using Ejercicio_1.Models;
using System;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class FormAgregarAlumnos : Form
    {
        public FormAgregarAlumnos()
        {
            InitializeComponent();

            ConfigDataGrid();
        }

        private void ConfigDataGrid()
        {
            // Configurar calificacionesGrid
            calificacionesGrid.ColumnCount = 3;
            for (int i = 0; i < 3; i++)
            {
                calificacionesGrid.Columns[i].Name = $"Calificación {i + 1}";
            }
            calificacionesGrid.Rows.Add(0, 0, 0); // Añade una fila con 0s
            calificacionesGrid.AllowUserToAddRows = false; // Evitar filas adicionales
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos vacíos
                if (string.IsNullOrWhiteSpace(txbCarnet.Text) ||
                    string.IsNullOrWhiteSpace(txbNombre.Text) ||
                    string.IsNullOrWhiteSpace(txbApellido.Text) ||
                    string.IsNullOrWhiteSpace(txbMateria.Text))
                {
                    MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validación de calificaciones
                float[] calificaciones = new float[3];
                for (int i = 0; i < 3; i++)
                {
                    if (!float.TryParse(calificacionesGrid.Rows[0].Cells[i].Value.ToString(), out calificaciones[i]) || calificaciones[i] < 0 || calificaciones[i] > 10)
                    {
                        MessageBox.Show($"Calificación {i + 1} no es válida. Debe ser un número entre 0 y 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Crear y guardar el nuevo alumno
                Alumno nuevoAlumno = new Alumno
                {
                    Carnet = txbCarnet.Text,
                    Nombre = txbNombre.Text,
                    Apellido = txbApellido.Text,
                    Materia = txbMateria.Text,
                    calificaciones = calificaciones
                };

                AppContext.AgregarAlumno(nuevoAlumno);

                MessageBox.Show("Alumno agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: Limpiar los campos para un nuevo ingreso
                txbCarnet.Clear();
                txbNombre.Clear();
                txbApellido.Clear();
                txbMateria.Clear();
                calificacionesGrid.Rows[0].SetValues(0, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
