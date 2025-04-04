using IpsCitasMedicasBackend.Models;
using IpsCitasMedicasBackend.Repositories.Interfaces;
using IpsCitasMedicasBackend.Data;
using Microsoft.EntityFrameworkCore;

namespace IpsCitasMedicasBackend.Repositories;
public class PacienteRepository : IPacienteRepository
{
    private readonly ApplicationDbContext _context;
    public PacienteRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Paciente? ObtenerPorDocumento(string documento)
    {
        return _context.Pacientes.FirstOrDefault(p => p.Documento == documento);
    }
}