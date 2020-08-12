using OracleConnection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OracleConnection.Interfaces
{
    public interface IEstudianteServices
    {
        List<Estudiante> ObtenerTodosEstudiantes();
        Estudiante ObtenerEstudiante(int carnet);
        Estudiante ActualizarEstudiante(Estudiante estudiante);

    }
}
