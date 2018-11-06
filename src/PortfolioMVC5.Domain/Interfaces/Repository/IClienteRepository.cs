using PortfolioMVC5.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioMVC5.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente> 
    {
        Cliente ObterPorCpf(string cpf);
        Cliente ObterPorEmail(string email);
    }
}
