namespace NanoGuardian.Api.Models
{
    public class AlertaZapato
    {
        public required string Usuario { get; set; }
        public int Impacto { get; set; } // Nivel de caída
        public string Estado { get; set; } = "Caida Detectada";
    }
}