using Microsoft.AspNetCore.Mvc;
using IpsCitasMedicasBackend.Services;
using IpsCitasMedicasBackend.Models;

namespace IpsCitasMedicasBackend.Controllers;

[Route("api/medicos")]
[ApiController]
public class MedicosController : ControllerBase
{
    private readonly MedicoService _medicoService;

    public MedicosController(MedicoService medicoService)
    {
        _medicoService = medicoService;
    }

    [HttpGet("especialidad/{especialidad}")]
    public ActionResult<IEnumerable<Medico>> ObtenerMedicosPorEspecialidad(string especialidad)
    {
        var medicos = _medicoService.ObtenerMedicosPorEspecialidad(especialidad);
        return Ok(medicos);
    }
}