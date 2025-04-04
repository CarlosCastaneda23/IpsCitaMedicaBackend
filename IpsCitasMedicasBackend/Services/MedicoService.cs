using IpsCitasMedicasBackend.Models;
using IpsCitasMedicasBackend.Repositories.Interfaces;

namespace IpsCitasMedicasBackend.Services;
public class MedicoService
{
    private readonly IMedicoRepository _medicoRepository;

    public MedicoService(IMedicoRepository medicoRepository)
    {
        _medicoRepository = medicoRepository;
    }

    public IEnumerable<Medico> ObtenerMedicosPorEspecialidad(string especialidad)
    {
        return _medicoRepository.ObtenerMedicosPorEspecialidad(especialidad);
    }
}