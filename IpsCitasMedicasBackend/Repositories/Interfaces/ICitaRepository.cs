using IpsCitasMedicasBackend.Models;

namespace IpsCitasMedicasBackend.Repositories.Interfaces;
public interface ICitaRepository
{
    IEnumerable<Cita> ObtenerCitasDisponibles(string especialidad);
    Cita? ObtenerCitaPorId(int id);
    void ReservarCita(Cita cita);
}