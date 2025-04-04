using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using IpsCitasMedicasBackend.Models;
using IpsCitasMedicasBackend.Data;

namespace IpsCitasBackend.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _config;

        public AuthController(ApplicationDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var paciente = _context.Pacientes
                .FirstOrDefault(p => p.Documento == request.Documento);

            if (paciente == null)
            {
                return Unauthorized(new { mensaje = "Credenciales incorrectas" });
            }

            var token = GenerateJwtToken(paciente);
            return Ok(new { token });
        }

        private string GenerateJwtToken(Paciente paciente)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, paciente.Documento),
                new Claim("id", paciente.Id.ToString()),
                new Claim("nombre", paciente.Nombres),
                new Claim("apellido", paciente.Apellidos),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(3),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }

    public class LoginRequest
    {
        public string Documento { get; set; }
    }
}
