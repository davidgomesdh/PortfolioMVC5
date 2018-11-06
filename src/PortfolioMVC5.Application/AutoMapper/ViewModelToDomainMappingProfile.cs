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
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappings";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ClienteEnderecoViewModel, Cliente>();
            Mapper.CreateMap<EnderecoViewModel, Endereco>();
            Mapper.CreateMap<ClienteEnderecoViewModel, Endereco>();
        }
    }
}
