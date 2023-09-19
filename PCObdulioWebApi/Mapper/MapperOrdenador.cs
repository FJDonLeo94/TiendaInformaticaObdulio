using Microsoft.Data.SqlClient;
using PCObdulioWebApi.Models;
using PruebaComponentesObdulio.Logica;

namespace PCObdulioWebApi.Mapper
{
    public class MapperOrdenador : IMapper<Ordenador>
    {
        public Ordenador Map(SqlDataReader json)
        {
            return new Ordenador()
            {
                Id = Convert.ToInt32(json["Id"]),
                Descripcion = Convert.ToString(json["Descripcion"]),
                PrecioTotal = Convert.ToDecimal(json["PrecioTotal"]),
                tipoOrdenador = (EnumOrdenador)Convert.ToInt32(json["tipoOrdenador"])

            };
        }
    }
}
