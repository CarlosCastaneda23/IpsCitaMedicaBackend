using IpsCitasMedicasBackend.Data;
using IpsCitasMedicasBackend.Models;
using IpsCitasMedicasBackend.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace IpsCitasMedicasBackend.Repositories;
public class MedicoRepository : IMedicoRepository
{
    private readonly ApplicationDbContext _context;

    public MedicoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Medico> ObtenerMedicosPorEspecialidad(string especialidad)
    {
        return _context.Medicos
            .Where(m => m.Especialidad == especialidad)
            .ToList();
    }

    public Medico? ObtenerMedicoPorId(int id)
    {
        return _context.Medicos.FirstOrDefault(m => m.Id == id);
    }
}