using Microsoft.Data.SqlClient;

namespace PCObdulioWebApi.Mapper
{
    public interface IMapper<T>
    {
        T Map(SqlDataReader json);
    }
}
