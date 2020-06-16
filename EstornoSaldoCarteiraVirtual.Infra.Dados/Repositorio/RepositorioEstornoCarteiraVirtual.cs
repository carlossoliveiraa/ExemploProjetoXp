using EstornoSaldoCarteiraVirtual.Dominio.Entidades;
using EstornoSaldoCarteiraVirtual.Dominio.Interfaces.Repositorio;
using EstornoSaldoCarteiraVirtual.Infra.Dados.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstornoSaldoCarteiraVirtual.Infra.Dados.Repositorio
{
    
    public class RepositorioEstornoCarteiraVirtual : RepositorioBasico<EstornoCarteiraVirtual>, IRepositorioEstornoCarteiraVirtual
    {
        public RepositorioEstornoCarteiraVirtual(ContextoEF contexto) : base(contexto)
        {
        }
    }
}
