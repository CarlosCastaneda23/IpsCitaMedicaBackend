using IpsCitasMedicasBackend.Models;
using IpsCitasMedicasBackend.Repositories.Interfaces;

namespace IpsCitasMedicasBackend.Services;
public class PacienteService
{
    private readonly IPacienteRepository _pacienteRepository;

    public PacienteService(IPacienteRepository pacienteRepository)
    {
        _pacienteRepository = pacienteRepository;
    }

    public Paciente? AutenticarPaciente(string documento)
    {
        return _pacienteRepository.ObtenerPorDocumento(documento);
    }
}