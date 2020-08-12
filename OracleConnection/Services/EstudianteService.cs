using Microsoft.Extensions.Configuration;
using OracleConnection.Interfaces;
using OracleConnection.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Components.Web;
using AutoMapper;

namespace OracleConnection.Services
{
    public class EstudianteService : IEstudianteServices
    {
        private readonly string _connection;
        private readonly IMapper _mapper;
        public EstudianteService(IConfiguration configuration,IMapper mapper)
        {
            _mapper = mapper;
            _connection = configuration.GetConnectionString("OracleProduccion");
        }
        public Estudiante ActualizarEstudiante(Estudiante estudiante)
        {
            throw new NotImplementedException();
        }

        public Estudiante ObtenerEstudiante(int carnet)
        {
            throw new NotImplementedException();
        }

        public List<Estudiante> ObtenerTodosEstudiantes()
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            try
            {
                using (var conn = new Oracle.ManagedDataAccess.Client.OracleConnection(_connection))
                {
                    using (var command = new OracleCommand())
                    {
                        conn.Open();
                        command.BindByName = true;
                        command.CommandText = "Select * from Estudiante";
                        OracleDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            var estudiante = _mapper.Map<Estudiante>(reader);
                            listaEstudiantes.Add(estudiante);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
            
            return listaEstudiantes;
        }
    }
}
