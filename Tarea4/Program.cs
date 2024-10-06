using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        Universidad universidad = new Universidad();

        universidad.RegistrarEstudiante(new Universidad.Estudiante("Juan Pérez", 10, 8));
        universidad.RegistrarEstudiante(new Universidad.Estudiante("María Gómez", 10, 7));
        universidad.RegistrarEstudiante(new Universidad.Estudiante("Carlos Ramírez", 10, 9));

        universidad.MostrarResumenEstudiantes();
    }
}
