using IpsCitasMedicasBackend.Models;
using IpsCitasMedicasBackend.Repositories.Interfaces;

namespace IpsCitasMedicasBackend.Services;
public class CitaService
{
    private readonly ICitaRepository _citaRepository;

    public CitaService(ICitaRepository citaRepository)
    {
        _citaRepository = citaRepository;
    }

    public IEnumerable<Cita> ObtenerCitasDisponibles(string especialidad)
    {
        return _citaRepository.ObtenerCitasDisponibles(especialidad);
    }

    public bool ReservarCita(int id)
    {
        var cita = _citaRepository.ObtenerCitaPorId(id);
        if (cita == null || cita.Estado == "Reservada") return false;

        _citaRepository.ReservarCita(cita);
        return true;
    }
}