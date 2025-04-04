using IpsCitasMedicasBackend.Data;
using IpsCitasMedicasBackend.Models;
using IpsCitasMedicasBackend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IpsCitasMedicasBackend.Repositories;

public class CitaRepository : ICitaRepository
{
    private readonly ApplicationDbContext _context;

    public CitaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Cita> ObtenerCitasDisponibles(string especialidad)
    {
        return _context.Citas
            .Include(c => c.Medico)
            .Where(c => c.Especialidad == especialidad && c.Estado == "Disponible")
            .OrderBy(c => c.FechaHora)
            .Take(5)
            .ToList();
    }

    public Cita? ObtenerCitaPorId(int id)
    {
        return _context.Citas
            .Include(c => c.Medico)
            .FirstOrDefault(c => c.Id == id);
    }

    public void ReservarCita(Cita cita)
    {
        cita.Estado = "Reservada";
        _context.Citas.Update(cita);
        _context.SaveChanges();
    }
}