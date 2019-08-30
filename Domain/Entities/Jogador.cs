using Domain.Enum;
using Domain.ValueObjects;
using System;

namespace Domain.Entities
{
    public class Jogador
    {
        public Guid JogadorId { get; set; }

        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string  Senha { get; set; }
        public EnumSituacaoJogador Status { get; set; }


    } 
}
