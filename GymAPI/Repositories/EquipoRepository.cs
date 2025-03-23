using GymAPI.Data;
using GymAPI.Interfaces;
using GymAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GymAPI.Repositories
{
    public class EquipoRepository : IEquipoRepository
    {
        private readonly GymContext _context;

        public EquipoRepository(GymContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Equipo>> GetEquipos()
        {
            return await _context.Equipos.ToListAsync();
        }

        public async Task<Equipo> GetEquipoById(int id)
        {
            return await _context.Equipos.FindAsync(id);
        }

        public async Task<Equipo> AddEquipo(Equipo equipo)
        {
            _context.Equipos.Add(equipo);
            await _context.SaveChangesAsync();
            return equipo;
        }

        public async Task<Equipo> UpdateEquipo(int id, Equipo equipo)
        {
            if (id != equipo.ID)
            {
                throw new ArgumentException("El ID del equipo no coincide.");
            }

            _context.Entry(equipo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return equipo;
        }

        public async Task<bool> DeleteEquipo(int id)
        {
            var equipo = await _context.Equipos.FindAsync(id);
            if (equipo == null)
            {
                return false;
            }

            _context.Equipos.Remove(equipo);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
