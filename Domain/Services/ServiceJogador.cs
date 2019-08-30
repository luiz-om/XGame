using Domain.Arguments.Jogador;
using Domain.Interfaces.Respository;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceJogador : IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;
        public ServiceJogador()
        {

        }
        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            Guid id = _repositoryJogador.AdicionarJogador(request);
            return new AdicionarJogadorResponse() { Id = id, Message = "Operação realizada com sucesso" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                throw new Exception("AutenticarJOgadorRequest é obrigatório");
            }

            if (string.IsNullOrEmpty(request.Email))
            {
                throw new Exception("Informe um e-mail");
            }
            if (IsEmail(request.Email))
            {
                throw new Exception("Informe um e-mail válido");

            }
            if (string.IsNullOrEmpty(request.Senha))
            {
                throw new Exception("Informe uma senha.");
            }
            if (request.Senha.Length < 6 )
            {
                throw new Exception("A senha deve conter no mínimo 6 caracteres");
            }

           var response= _repositoryJogador.AutenticarJogador(request);

            return response;
        }

        private bool IsEmail(string email)
        {
            return false;
        }
    }
}
