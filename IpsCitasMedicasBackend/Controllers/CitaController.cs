using Microsoft.AspNetCore.Mvc;
using IpsCitasMedicasBackend.Services;
using IpsCitasMedicasBackend.Models;

namespace IpsCitasMedicasBackend.Controllers;

[Route("api/citas")]
[ApiController]
public class CitaController : ControllerBase
{
    private readonly CitaService _citaService;

    public CitaController(CitaService citaService)
    {
        _citaService = citaService;
    }

    [HttpGet("disponibles/{especialidad}")]
    public ActionResult<IEnumerable<Cita>> ObtenerCitasDisponibles(string especialidad)
    {
        var citas = _citaService.ObtenerCitasDisponibles(especialidad);
        return Ok(citas);
    }

    [HttpPost("reservar/{id}")]
    public IActionResult ReservarCita(int id)
    {
        bool reservado = _citaService.ReservarCita(id);
        if (!reservado) return BadRequest("No se pudo reservar la cita.");
        return Ok("Cita reservada con éxito.");
    }
}