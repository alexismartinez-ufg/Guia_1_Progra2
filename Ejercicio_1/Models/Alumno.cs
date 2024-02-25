namespace Ejercicio_1.Models
{
    public class Alumno
    {
        public string Carnet { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string Materia { get; set; } = "";
        public float[] calificaciones { get; set; } = new float[3];
    }
}
