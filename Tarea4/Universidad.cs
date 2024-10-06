using System;
using System.Collections.Generic;
using Tarea4;

public class Universidad
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int SesionesTotales { get; set; }
        public int SesionesAsistidas { get; set; }

        public class Asistencia
        {
            public static double CalcularPorcentajeAsistencia(int sesionesAsistidas, int sesionesTotales)
            {
                return (double)sesionesAsistidas / sesionesTotales * 100;
            }

            public static bool VerificarMinimoAsistencia(double porcentaje)
            {
                return porcentaje >= 75;
            }
        }
        public Estudiante(string nombre, int sesionesTotales, int sesionesAsistidas)
        {
            Nombre = nombre;
            SesionesTotales = sesionesTotales;
            SesionesAsistidas = sesionesAsistidas;
        }
    }

        public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

        public void RegistrarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public void MostrarResumenEstudiantes()
        {
            foreach (var estudiante in Estudiantes)
            {
                estudiante.MostrarInformacionExtendida(); 
            }
        }
}
    
