using IpsCitasMedicasBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace IpsCitasMedicasBackend.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Cita> Citas { get; set; }
    public DbSet<Medico> Medicos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // 🔹 MÉDICOS
        modelBuilder.Entity<Medico>().HasData(
                new Medico { Id = 1, Nombre = "Dr. Juan Pérez", Especialidad = "Odontologia" },
                new Medico { Id = 2, Nombre = "Dra. Ana Gómez", Especialidad = "Medicina General" },
                new Medico { Id = 3, Nombre = "Dr. Luis Martínez", Especialidad = "Odontologia" },
                new Medico { Id = 4, Nombre = "Dra. Camila López", Especialidad = "Medicina General" },
                new Medico { Id = 5, Nombre = "Dr. Sergio Rojas", Especialidad = "Odontologia" },
                new Medico { Id = 6, Nombre = "Dra. Paula Ruiz", Especialidad = "Medicina General" },
                new Medico { Id = 7, Nombre = "Dr. Mario Torres", Especialidad = "Odontologia" },
                new Medico { Id = 8, Nombre = "Dra. Diana Castro", Especialidad = "Medicina General" },
                new Medico { Id = 9, Nombre = "Dr. Andrés Vélez", Especialidad = "Odontologia" },
                new Medico { Id = 10, Nombre = "Dra. Lorena Mendoza", Especialidad = "Medicina General" },
                new Medico { Id = 11, Nombre = "Dr. Esteban Naranjo", Especialidad = "Odontologia" },
                new Medico { Id = 12, Nombre = "Dra. Silvia Cárdenas", Especialidad = "Medicina General" },
                new Medico { Id = 13, Nombre = "Dr. Felipe Gómez", Especialidad = "Odontologia" },
                new Medico { Id = 14, Nombre = "Dra. Marcela Duarte", Especialidad = "Medicina General" },
                new Medico { Id = 15, Nombre = "Dr. Pedro Lozano", Especialidad = "Odontologia" },
                new Medico { Id = 16, Nombre = "Dra. Claudia Ramírez", Especialidad = "Medicina General" },
                new Medico { Id = 17, Nombre = "Dr. Ricardo Torres", Especialidad = "Odontologia" },
                new Medico { Id = 18, Nombre = "Dra. Patricia Ortiz", Especialidad = "Medicina General" },
                new Medico { Id = 19, Nombre = "Dr. Julián Arias", Especialidad = "Odontologia" },
                new Medico { Id = 20, Nombre = "Dra. Carolina Silva", Especialidad = "Medicina General" }
        );

        // 🔹 PACIENTES
        modelBuilder.Entity<Paciente>().HasData(
                new Paciente { Id = 1, Nombres = "Carlos", Apellidos = "Ramírez", Documento = "123456789", FechaNacimiento = new DateTime(1995, 5, 10, 10, 0, 0), Telefono = "3001234567" },
                new Paciente { Id = 2, Nombres = "Laura", Apellidos = "Gómez", Documento = "987654321", FechaNacimiento = new DateTime(1988, 8, 15, 8, 30, 0), Telefono = "3019876543" },
                new Paciente { Id = 3, Nombres = "Sofía", Apellidos = "Fernández", Documento = "1122334455", FechaNacimiento = new DateTime(2000, 12, 25, 14, 15, 0), Telefono = "3152223344" },
                new Paciente { Id = 4, Nombres = "Andrés", Apellidos = "Pérez", Documento = "123123123", FechaNacimiento = new DateTime(1990, 1, 1), Telefono = "3101231231" },
                new Paciente { Id = 5, Nombres = "Lucía", Apellidos = "Rodríguez", Documento = "456456456", FechaNacimiento = new DateTime(1993, 3, 5), Telefono = "3124564567" },
                new Paciente { Id = 6, Nombres = "Mateo", Apellidos = "Hernández", Documento = "789789789", FechaNacimiento = new DateTime(1999, 6, 10), Telefono = "3117897897" },
                new Paciente { Id = 7, Nombres = "Valentina", Apellidos = "Jiménez", Documento = "321321321", FechaNacimiento = new DateTime(2001, 9, 20), Telefono = "3163213213" },
                new Paciente { Id = 8, Nombres = "Sebastián", Apellidos = "López", Documento = "654654654", FechaNacimiento = new DateTime(1985, 11, 30), Telefono = "3136546546" },
                new Paciente { Id = 9, Nombres = "Camila", Apellidos = "Torres", Documento = "987987987", FechaNacimiento = new DateTime(2002, 2, 14), Telefono = "3179879879" },
                new Paciente { Id = 10, Nombres = "Daniel", Apellidos = "Ruiz", Documento = "741741741", FechaNacimiento = new DateTime(1996, 4, 18), Telefono = "3187417417" },
                new Paciente { Id = 11, Nombres = "Manuela", Apellidos = "Mendoza", Documento = "852852852", FechaNacimiento = new DateTime(1994, 7, 22), Telefono = "3148528528" },
                new Paciente { Id = 12, Nombres = "Tomás", Apellidos = "Suárez", Documento = "963963963", FechaNacimiento = new DateTime(1991, 10, 8), Telefono = "3199639639" },
                new Paciente { Id = 13, Nombres = "Isabella", Apellidos = "Moreno", Documento = "159159159", FechaNacimiento = new DateTime(2003, 5, 5), Telefono = "3201591591" },
                new Paciente { Id = 14, Nombres = "Julián", Apellidos = "Castro", Documento = "753753753", FechaNacimiento = new DateTime(1987, 3, 12), Telefono = "3227537537" },
                new Paciente { Id = 15, Nombres = "Gabriela", Apellidos = "Ríos", Documento = "951951951", FechaNacimiento = new DateTime(1992, 8, 27), Telefono = "3239519519" },
                new Paciente { Id = 16, Nombres = "Felipe", Apellidos = "Peña", Documento = "357357357", FechaNacimiento = new DateTime(1989, 12, 3), Telefono = "3243573573" },
                new Paciente { Id = 17, Nombres = "Daniela", Apellidos = "Ortega", Documento = "258258258", FechaNacimiento = new DateTime(1998, 6, 17), Telefono = "3252582582" },
                new Paciente { Id = 18, Nombres = "Santiago", Apellidos = "Vargas", Documento = "654321654", FechaNacimiento = new DateTime(1990, 9, 25), Telefono = "3266543216" },
                new Paciente { Id = 19, Nombres = "Mariana", Apellidos = "Silva", Documento = "369369369", FechaNacimiento = new DateTime(1997, 1, 29), Telefono = "3273693693" },
                new Paciente { Id = 20, Nombres = "Alejandro", Apellidos = "Castaño", Documento = "147147147", FechaNacimiento = new DateTime(2001, 11, 11), Telefono = "3281471471" }
        );

        // 🔹 CITAS
        modelBuilder.Entity<Cita>().HasData(
            new Cita { Id = 1, Especialidad = "Medicina General", FechaHora = new DateTime(2025, 4, 5, 10, 0, 0), Estado = "Disponible", MedicoId = 1 },
            new Cita { Id = 2, Especialidad = "Odontología", FechaHora = new DateTime(2025, 4, 6, 11, 30, 0), Estado = "Disponible", MedicoId = 2 },
            new Cita { Id = 3, Especialidad = "Medicina General", FechaHora = new DateTime(2025, 4, 7, 9, 0, 0), Estado = "Disponible", MedicoId = 3 },
            new Cita { Id = 4, Especialidad = "Odontologia", FechaHora = new DateTime(2025, 4, 8, 14, 15, 0), Estado = "Disponible", MedicoId = 4 },
            new Cita { Id = 5, Especialidad = "Medicina General", FechaHora = new DateTime(2025, 4, 9, 10, 0, 0), Estado = "Disponible", MedicoId = 1 },
            new Cita { Id = 6, Especialidad = "Odontología", FechaHora = new DateTime(2025, 4, 10, 15, 0, 0), Estado = "Disponible", MedicoId = 2 },
            new Cita { Id = 7, Especialidad = "Medicina General", FechaHora = new DateTime(2025, 4, 11, 13, 0, 0), Estado = "Disponible", MedicoId = 3 },
            new Cita { Id = 8, Especialidad = "Odontologia", FechaHora = new DateTime(2025, 4, 12, 8, 30, 0), Estado = "Disponible", MedicoId = 4 },
            new Cita { Id = 9, Especialidad = "Medicina General", FechaHora = new DateTime(2025, 4, 13, 16, 45, 0), Estado = "Disponible", MedicoId = 1 },
            new Cita { Id = 10, Especialidad = "Odontología", FechaHora = new DateTime(2025, 4, 14, 9, 30, 0), Estado = "Disponible", MedicoId = 2 },
            new Cita { Id = 11, Especialidad = "Medicina General", FechaHora = new DateTime(2025, 4, 15, 11, 15, 0), Estado = "Disponible", MedicoId = 3 },
            new Cita { Id = 12, Especialidad = "Odontologia", FechaHora = new DateTime(2025, 4, 16, 14, 0, 0), Estado = "Disponible", MedicoId = 4 },
            new Cita { Id = 13, Especialidad = "Medicina General", FechaHora = new DateTime(2025, 4, 17, 12, 30, 0), Estado = "Disponible", MedicoId = 1 },
            new Cita { Id = 14, Especialidad = "Odontología", FechaHora = new DateTime(2025, 4, 18, 10, 0, 0), Estado = "Disponible", MedicoId = 2 },
            new Cita { Id = 15, Especialidad = "Medicina General", FechaHora = new DateTime(2025, 4, 19, 8, 45, 0), Estado = "Disponible", MedicoId = 3 },
            new Cita { Id = 16, Especialidad = "Odontologia", FechaHora = new DateTime(2025, 4, 20, 13, 30, 0), Estado = "Disponible", MedicoId = 4 },
            new Cita { Id = 17, Especialidad = "Medicina General", FechaHora = new DateTime(2025, 4, 21, 15, 45, 0), Estado = "Disponible", MedicoId = 1 },
            new Cita { Id = 18, Especialidad = "Odontología", FechaHora = new DateTime(2025, 4, 22, 9, 0, 0), Estado = "Disponible", MedicoId = 2 },
            new Cita { Id = 19, Especialidad = "Medicina General", FechaHora = new DateTime(2025, 4, 23, 10, 30, 0), Estado = "Disponible", MedicoId = 3 },
            new Cita { Id = 20, Especialidad = "Odontologia", FechaHora = new DateTime(2025, 4, 24, 11, 45, 0), Estado = "Disponible", MedicoId = 4 }
        );

    }
}