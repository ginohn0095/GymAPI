using GymAPI.Models;

namespace GymAPI.Interfaces
{
    public interface IEquipoRepository
    {
        Task<IEnumerable<Equipo>> GetEquipos();
        Task<Equipo> GetEquipoById(int id);
        Task<Equipo> AddEquipo(Equipo equipo);
        Task<Equipo> UpdateEquipo(int id, Equipo equipo);
        Task<bool> DeleteEquipo(int id);
    }
}
