using GymAPI.Models;

namespace GymAPI.Interfaces
{
    public interface IProveedorRepository
    {
        Task<IEnumerable<Proveedor>> GetProveedores();
        Task<Proveedor> GetProveedorById(int id);
    }
}
