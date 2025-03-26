using GymAPI.Interfaces;
using GymAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymAPI.Controllers
{
    [ApiController]
    [Authorize] // 👈 Protege todos los endpoints
    
    [Route("api/[controller]")]
    public class EquiposController : ControllerBase
    {
        private readonly IEquipoRepository _equipoRepository;

        public EquiposController(IEquipoRepository equipoRepository)
        {
            _equipoRepository = equipoRepository;
        }

        // GET: api/Equipos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipo>>> GetEquipos()
        {
            var equipos = await _equipoRepository.GetEquipos();
            return Ok(equipos);
        }

        // GET: api/Equipos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Equipo>> GetEquipo(int id)
        {
            var equipo = await _equipoRepository.GetEquipoById(id);

            if (equipo == null)
            {
                return NotFound();
            }

            return Ok(equipo);
        }

        // POST: api/Equipos
        [HttpPost]
        public async Task<ActionResult<Equipo>> PostEquipo(Equipo equipo)
        {
            var newEquipo = await _equipoRepository.AddEquipo(equipo);
            return CreatedAtAction(nameof(GetEquipo), new { id = newEquipo.ID }, newEquipo);
        }

        // PUT: api/Equipos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipo(int id, Equipo equipo)
        {
            try
            {
                var updatedEquipo = await _equipoRepository.UpdateEquipo(id, equipo);
                return Ok(updatedEquipo);
            }
            catch (ArgumentException)
            {
                return BadRequest("El ID del equipo no coincide.");
            }
        }

        // DELETE: api/Equipos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEquipo(int id)
        {
            var result = await _equipoRepository.DeleteEquipo(id);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}

