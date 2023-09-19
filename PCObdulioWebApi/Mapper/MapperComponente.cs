using Microsoft.Data.SqlClient;
using NewTiendaInformatica.Componentes;
using Componente = PCObdulioWebApi.Models.Componente;

namespace PCObdulioWebApi.Mapper
{
    public class MapperComponente : IMapper<Componente>
    {
        public Componente Map(SqlDataReader json)
        {
            return new Componente()
            {
                Id = Convert.ToInt32(json["Id"]),
                Calor = Convert.ToInt32(json["Calor"]),
                Cores = Convert.ToInt32(json["Cores"]),
                Coste = Convert.ToDouble(json["Coste"]),
                Descripcion = Convert.ToString(json["Descripcion"]),
                Megas = Convert.ToInt64(json["Megas"]),
                NumeroSerie = Convert.ToString(json["NumeroSerie"]),
                TipoComponente = (EnumTipoComponente)Convert.ToInt32(json["TipoComponente"])

            };
        }
    }
}
