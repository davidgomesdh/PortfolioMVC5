using AutoMapper;
using PortfolioMVC5.Application.ViewModels;
using PortfolioMVC5.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioMVC5.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Cliente, ClienteEnderecoViewModel>();
            Mapper.CreateMap<Endereco, EnderecoViewModel>();
            Mapper.CreateMap<Endereco, ClienteEnderecoViewModel>();
        }
    }
}
