using PortfolioMVC5.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioMVC5.Infra.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(e => e.EnderecoId);

            Property(c => c.Logradouro)
                  .IsRequired()
                  .HasMaxLength(150);

            Property(c => c.Numero)
                  .IsRequired()
                  .HasMaxLength(100);

            Property(c => c.Bairro)
                 .IsRequired()
                 .HasMaxLength(50);

            Property(c => c.CEP)
                 .IsRequired()
                 .HasMaxLength(8);

            Property(c => c.Complemento)
                 .IsRequired()
                 .HasMaxLength(100);

            HasRequired(e => e.Cliente)
                .WithMany(c => c.Enderecos)
                .HasForeignKey(e => e.ClienteId);

            ToTable("Enderecos");
            
        }
    }
}
