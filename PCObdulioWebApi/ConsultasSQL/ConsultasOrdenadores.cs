using PCObdulioWebApi.Models;

namespace PCObdulioWebApi.ConsultasSQL
{
    public class ConsultasOrdenadores : IConsultas<Ordenador>
    {
        public string ObtenerTodos()
        {
            return "Select * From Ordenadores";
        }

        public string Obtener(int id)
        {
            return $"SELECT * FROM Ordenadores WHERE Id = {id}";
        }

        public string Añadir(Ordenador item)
        {
            return "INSERT INTO Ordenadores (Descripcion, PrecioTotal, tipoOrdenador)" + 
                   "VALUES" +
                   $"('{item.Descripcion}', '{item.PrecioTotal}', '{(int)item.tipoOrdenador}')";
        }

        public string Borrar(int id)
        {
            return $"DELETE FROM Ordenadores WHERE Id = {id}";
        }

        public string Actualizar(Ordenador item)
        {
            return "UPDATE Ordenadores SET " +
                   
                   $"tipoOrdenador = '{(int)item.tipoOrdenador}'," +
                   $"PrecioTotal = '{item.PrecioTotal}'," +
                   $"Descripcion = '{item.Descripcion}'" +
                   $"WHERE Id = {item.Id}";
        }

        public string ObtenerUltimoId()
        {
            return "SELECT MAX(Id) AS Id FROM Ordenadores";
        }
    }
}
