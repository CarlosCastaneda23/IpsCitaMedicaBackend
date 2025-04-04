using Microsoft.AspNetCore.Mvc;
using IpsCitasMedicasBackend.Services;
using IpsCitasMedicasBackend.Models;
using IpsCitasMedicasBackend.DTOs;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace IpsCitasMedicasBackend.Controllers;

[Route("api/pacientes")]
[ApiController]
public class PacientesController : ControllerBase
{
    private readonly PacienteService _pacienteService;
    private readonly IConfiguration _configuration;

    public PacientesController(PacienteService pacienteService, IConfiguration configuration)
    {
        _pacienteService = pacienteService;
        _configuration = configuration;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] PacienteDto loginDto)
    {
        var paciente = _pacienteService.AutenticarPaciente(loginDto.Documento);
        if (paciente == null) return Unauthorized("Credenciales incorrectas.");

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, paciente.Id.ToString()),
                new Claim(ClaimTypes.Name, paciente.Nombres)
            }),
            Expires = DateTime.UtcNow.AddHours(2),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);

        return Ok(new { Token = tokenHandler.WriteToken(token) });
    }
}