namespace IpsCitasMedicasBackend.Models;
public class Cita
{
    public int Id { get; set; }
    public string Especialidad { get; set; }
    public DateTime FechaHora { get; set; }
    public string Estado { get; set; } = "Disponible";
    public int MedicoId { get; set; }
    public Medico Medico { get; set; }
}