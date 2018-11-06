﻿using PortfolioMVC5.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioMVC5.Application.ViewModels;
using PortfolioMVC5.Infra.Data.Repository;
using AutoMapper;
using PortfolioMVC5.Domain.Entities;

namespace PortfolioMVC5.Application
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly ClienteRepository _clienteRepository;
        public ClienteAppService()
        {
            _clienteRepository = new ClienteRepository();
        }


        public ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel obj)
        {
            var cliente = Mapper.Map<ClienteEnderecoViewModel, Cliente>(obj);
            var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(obj);

            cliente.Enderecos.Add(endereco);
            _clienteRepository.Adicionar(cliente);

            return obj;
        }

        public ClienteViewModel Atualizar(ClienteViewModel obj)
        {
            var cliente = Mapper.Map<ClienteViewModel, Cliente>(obj);
            _clienteRepository.Atualizar(cliente);
            return obj;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel ObterPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteRepository.ObterTodos());
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}