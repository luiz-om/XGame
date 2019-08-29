using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Jogador
    {
        public Guid JogadorId { get; set; }

        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public string  Senha { get; set; }
        public int Status { get; set; }


    } 
}
