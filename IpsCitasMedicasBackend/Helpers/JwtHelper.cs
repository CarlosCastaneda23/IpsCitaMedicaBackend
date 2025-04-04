using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using IpsCitasMedicasBackend.Models;

namespace IpsCitasMedicasBackend.Helpers;

public class JwtHelper
{
    private static string secretKey = "TuClaveSuperSecreta";

    public static string GenerarToken(Paciente paciente)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, paciente.Nombres),
            new Claim("Documento", paciente.Documento)
        };

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.UtcNow.AddHours(2),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}