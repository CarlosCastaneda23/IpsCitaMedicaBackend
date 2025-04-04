namespace IpsCitasMedicasBackend.DTOs;

public class CitaDto
{
    public int Id { get; set; }
    public string Especialidad { get; set; }
    public DateTime FechaHora { get; set; }
    public string Estado { get; set; }
    public int MedicoId { get; set; }
    public string NombreMedico { get; set; }
}