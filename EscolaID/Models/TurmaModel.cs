namespace EscolaID.Models
{
    public class TurmaModel
    {
        public int Id { get; set; }

        public int EscolaId { get; set; }

        public string TurmaName { get; set; }

        public string? TipoTurma { get; set; }
    }
}
