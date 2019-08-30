using Domain.Arguments.Jogador;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicinado...");
            var service = new ServiceJogador();
            Console.WriteLine("Criei instancia do servico");

            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criei a instancia do objeto");
            request.Email = "Maria.com";
            var response = service.AutenticarJogador(request);
            Console.ReadLine();


        }
    }
}
