using IpsCitasMedicasBackend.Models;

namespace IpsCitasMedicasBackend.Repositories.Interfaces;
public interface IPacienteRepository
{
    Paciente? ObtenerPorDocumento(string documento);
}