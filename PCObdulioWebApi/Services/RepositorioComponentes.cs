using Microsoft.Data.SqlClient;
using PCObdulioWebApi.ConsultasSQL;
using PCObdulioWebApi.Mapper;
using PCObdulioWebApi.Models;
using PCObdulioWebApi.Data;


namespace PCObdulioWebApi.Services
{
    public class RepositorioComponentes : IRepositorio<Componente>
    {
        private readonly SqlConnection conexion;
        readonly IMapper<Componente> mapper;
        readonly ConsultasComponente consulta;
       
        public RepositorioComponentes(ADOContext context)
        {
            conexion = context.GetConnection();
            mapper = new MapperComponente();
            consulta = new ConsultasComponente();
        }
        public List<Componente> ObtenerTodos()
        {
            var componentes = new List<Componente>();
            string sql = consulta.ObtenerTodos();
            SqlCommand command = new SqlCommand(sql, conexion);
            conexion.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                componentes.Add(mapper.Map(dataReader));
            }
            conexion.Close();
            return componentes;
        }

        public Componente? Obtener(int id)
        {
            Componente? componente;
            string sql = consulta.Obtener(id);
            SqlCommand command = new SqlCommand(sql, conexion);
            conexion.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                componente = mapper.Map(dataReader);
            }
            else
            {
                componente = null;
            }
            conexion.Close();
            return componente;
        }

        public void Añadir(Componente item)
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

        public void Actualizar(Componente item)
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
