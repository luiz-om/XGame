using System;

namespace Domain.Entities
{
    public class MeuJogo
    {
        public Guid MeusJogosId { get; set; }
        public JogoPlataforma JogoPlataforma { get; set; }
        public bool Desejo { get; set; }
        public DateTime DataDesejo { get; set; }
        public bool Troco { get; set; }
        public bool Vendo { get; set; }

    }
}
