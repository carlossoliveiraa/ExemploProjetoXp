using EstornoSaldoCarteiraVirtual.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstornoSaldoCarteiraVirtual.Infra.Dados.Mapeamento
{
    public class EstornoCarteiraVirtualMap : MapeamentoBasico<EstornoCarteiraVirtual>
    {
        public override void Configure(EntityTypeBuilder<EstornoCarteiraVirtual> builder)
        {
            base.Configure(builder);
            builder.ToTable("EstornoCarteiraVirtual");
            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
            builder.Property(c => c.Valor).HasColumnName("Valor");
            builder.Property(c => c.Frotista).HasColumnName("Frotista");
            builder.Property(c => c.Quantidade).HasColumnName("Quantidade");
            builder.Property(c => c.EmpresaFrotistaId).HasColumnName("EmpresaFrotistaId");
        }
    }
}
