using PCObdulioWebApi.Models;

namespace PCObdulioWebApi.ConsultasSQL
{
    public class ConsultasComponente : IConsultas<Componente>
    {
        public string ObtenerTodos()
        {
            return "Select * From Componentes";
        }

        public string Obtener(int id)
        {
            return $"SELECT * FROM Componentes WHERE Id = {id}";
        }

        public string Añadir(Componente item)
        {
            return "INSERT INTO Componentes" + "(NumeroSerie, Descripcion, Coste, Calor, Cores, Megas, TipoComponente)"
                                             + "VALUES" +
                                             $"('{item.NumeroSerie}', '{item.Descripcion}', '{item.Coste}', '{item.Calor}', '{item.Cores}', '{item.Megas}', '{(int)item.TipoComponente}')";

        }

        public string Borrar(int id)
        {
            return $"DELETE FROM Componentes WHERE Id = {id}";
        }

        public string Actualizar(Componente item)
        {
            return "UPDATE Componentes SET " +
                  $"NumeroSerie = '{item.NumeroSerie}'," +
                  $"Cores = '{item.Cores}'," +
                  $"Calor = '{item.Calor}'," +
                  $"Coste = '{item.Coste}'," +
                  $"TipoComponente = '{(int)item.TipoComponente}', " +
                  $"Megas = '{item.Megas}'," +
                  $"Descripcion = '{item.Descripcion}'" +
                  $"WHERE Id = {item.Id}";

        }

        public string ObtenerUltimoId()
        {
            return "SELECT MAX(Id) AS Id FROM Componentes";
        }
    }
}
