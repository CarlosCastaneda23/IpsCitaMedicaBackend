using IpsCitasMedicasBackend.Models;

namespace IpsCitasMedicasBackend.Repositories.Interfaces;
public interface IMedicoRepository
{
    IEnumerable<Medico> ObtenerMedicosPorEspecialidad(string especialidad);
    Medico? ObtenerMedicoPorId(int id);
}