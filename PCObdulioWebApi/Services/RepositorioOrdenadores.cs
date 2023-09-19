using Microsoft.Data.SqlClient;
using PCObdulioWebApi.ConsultasSQL;
using PCObdulioWebApi.Data;
using PCObdulioWebApi.Mapper;
using PCObdulioWebApi.Models;

namespace PCObdulioWebApi.Services
{
    public class RepositorioOrdenadores : IRepositorio<Ordenador>
    {
        private readonly SqlConnection conexion;
        readonly IMapper<Ordenador> mapper;
        readonly ConsultasOrdenadores consulta;

        public RepositorioOrdenadores(ADOContext context)
        {
            conexion = context.GetConnection();
            mapper = new MapperOrdenador();
            consulta = new ConsultasOrdenadores();
        }
        public List<Ordenador> ObtenerTodos()
        {
            var ordenadores = new List<Ordenador>();
            string sql = consulta.ObtenerTodos();
            SqlCommand command = new SqlCommand(sql, conexion);
            conexion.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ordenadores.Add(mapper.Map(dataReader));
            }
            conexion.Close();
            return ordenadores;
        }

        public Ordenador? Obtener(int id)
        {
            Ordenador? pc;
            string sql = consulta.Obtener(id);
            SqlCommand command = new SqlCommand(sql, conexion);
            conexion.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                pc = mapper.Map(dataReader);
            }
            else
            {
                pc = null;
            }
            conexion.Close();
            return pc;
        }

        public void Añadir(Ordenador item)
        {
            string sql = consulta.Añadir(item);
            SqlCommand command = new SqlCommand(sql, conexion);
            conexion.Open();
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public void Borrar(int id)
        {
            string sql = consulta.Borrar(id);
            SqlCommand command = new SqlCommand(sql, conexion);
            conexion.Open();
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public void Actualizar(Ordenador item)
        {
            string sql = consulta.Actualizar(item);
            SqlCommand command = new SqlCommand(sql, conexion);
            conexion.Open();
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public int ObtenerUltimoId()
        {
            int ultimoid;
            string sql = consulta.ObtenerUltimoId();
            SqlCommand command = new SqlCommand(sql, conexion);
            conexion.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                ultimoid = mapper.Map(dataReader).Id;
            }
            else
            {
                ultimoid = 0;
            }
            conexion.Close();
            return ultimoid;
        }
    }
}
