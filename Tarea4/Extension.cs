using System;

namespace Tarea4
{
    public static class EstudianteExtension
    {
        public static void MostrarInformacionExtendida(this Universidad.Estudiante estudiante)
        {
            double porcentaje = Universidad.Estudiante.Asistencia.CalcularPorcentajeAsistencia(estudiante.SesionesAsistidas, estudiante.SesionesTotales);
            bool cumpleRequisito = Universidad.Estudiante.Asistencia.VerificarMinimoAsistencia(porcentaje);
            string estado = cumpleRequisito ? "Aprobado" : "No Aprobado";

            Console.WriteLine($"Estudiante: {estudiante.Nombre}");
            Console.WriteLine($"Sesiones Totales: {estudiante.SesionesTotales}");
            Console.WriteLine($"Sesiones Asistidas: {estudiante.SesionesAsistidas}");
            Console.WriteLine($"Porcentaje de Asistencia: {porcentaje:F2}%");
            Console.WriteLine($"Estado: {estado}");
            Console.WriteLine();
        }
    }
}
