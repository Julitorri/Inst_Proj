using System;
namespace Inst.Models

{
    public class InstModels
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int? Nif { get; set; }

        public string? CursoEscolhido { get; set; }
        //public DateTime DataRegistro { get; set; } = DateTime.Now;
        public string? Email { get; set; } 

        public int password { get; set; }

    }
}
