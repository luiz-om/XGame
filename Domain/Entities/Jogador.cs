using Domain.Enum;
using Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using System;

namespace Domain.Entities
{
    public class Jogador : Notifiable
    {
        public Jogador()
        {
        }

        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this)
                .IfNotEmail(x => x.Email.Endereco,"Informe um e-mail válido")
                .IfNullOrInvalidLength(x=>x.Senha, 6,32, "A senha deve ter no minimo 6 caracters e no maximo 32");
        }

        public Guid JogadorId { get; set; }

        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string  Senha { get; set; }
        public EnumSituacaoJogador Status { get; set; }


    } 
}
