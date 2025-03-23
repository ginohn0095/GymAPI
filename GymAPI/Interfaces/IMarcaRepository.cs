using GymAPI.Models;

namespace GymAPI.Interfaces
{
    public interface IMarcaRepository
    {
        Task<IEnumerable<Marca>> GetMarcas();
        Task<Marca> GetMarcaById(int id);
    }
}
