using GymAPI.Data;
using GymAPI.Interfaces;
using GymAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GymAPI.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly GymContext _context;

        public ProveedorRepository(GymContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Proveedor>> GetProveedores()
        {
            return await _context.Proveedores.ToListAsync();
        }

        public async Task<Proveedor> GetProveedorById(int id)
        {
            return await _context.Proveedores.FindAsync(id);
        }
    }
}
