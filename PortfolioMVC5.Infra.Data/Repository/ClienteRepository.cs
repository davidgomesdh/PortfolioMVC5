using PortfolioMVC5.Domain.Entities;
using PortfolioMVC5.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioMVC5.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public Cliente ObterPorCpf(string cpf)
        {
            return Db.Clientes.Where(c => c.CPF == cpf).ToList().FirstOrDefault();
        }

        public Cliente ObterPorEmail(string email)
        {
            return Db.Clientes.Where(c => c.Email == email).ToList().FirstOrDefault();
        }

        public override void Remover(Guid id)
        {
            var cliente = new Cliente() { ClienteId = id };
            DbSet.Remove(cliente);
            SaveChanges();
        }
    }
}
