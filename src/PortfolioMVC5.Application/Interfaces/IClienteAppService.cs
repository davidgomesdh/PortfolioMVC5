using PortfolioMVC5.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioMVC5.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel obj);
        ClienteViewModel ObterPorId(Guid id);
        IEnumerable<ClienteViewModel> ObterTodos();
        ClienteViewModel Atualizar(ClienteViewModel obj);
        void Remover(Guid id);
        ClienteViewModel ObterPorCpf(string cpf);
        ClienteViewModel ObterPorEmail(string email);

    }
}
