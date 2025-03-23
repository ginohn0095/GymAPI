using GymAPI.Data;
using GymAPI.Interfaces;
using GymAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GymAPI.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {
        private readonly GymContext _context;

        public MarcaRepository(GymContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Marca>> GetMarcas()
        {
            return await _context.Marcas.ToListAsync();
        }

        public async Task<Marca> GetMarcaById(int id)
        {
            return await _context.Marcas.FindAsync(id);
        }
    }
}
