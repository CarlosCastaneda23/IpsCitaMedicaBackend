using IpsCitasMedicasBackend.Models;
using IpsCitasMedicasBackend.Repositories.Interfaces;

namespace IpsCitasMedicasBackend.Services;
public class AuthService
{
    private readonly IPacienteRepository _pacienteRepository;
    public AuthService(IPacienteRepository pacienteRepository)
    {
        _pacienteRepository = pacienteRepository;
    }

    public Paciente? Autenticar(string documento, DateTime fechaNacimiento)
    {
        var paciente = _pacienteRepository.ObtenerPorDocumento(documento);
        if (paciente != null && paciente.FechaNacimiento == fechaNacimiento)
        {
            return paciente;
        }
        return null;
    }
}