using Asp.Versioning;
using GymAPI.Data;
using GymAPI.Interfaces;
using GymAPI.Models;
using GymAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace GymAPI.Controllers
{

    [ApiController]
    [Authorize(Roles = "Admin")]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/equipos")]
    public class EquipoControllerV2:ControllerBase
    {
        private readonly IEquipoRepository _equipoRepository;
        public EquipoControllerV2(IEquipoRepository equipoRepository)
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

        


    }
}
