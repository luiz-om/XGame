using Domain.Arguments.Plataforma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IServicePlataforma
    {
        AdicionarPlatafromaResponse AdicionarPlatafroma(AdicionarPlataformRequest request)
    }
}
