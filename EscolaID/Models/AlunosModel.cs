using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace EscolaID.Models
{
    public class AlunosModel
    {
        public int Id { get; set; }
        public int EscolaId { get; set; }
        public int TurmaId { get; set; }
        public string Aluno { get; set; }
        public int? Idade { get; set; }


    }
}
