using AutoMapper;
using EstornoSaldoCarteiraVirtual.Aplicacao.Dto;
using EstornoSaldoCarteiraVirtual.Aplicacao.Interfaces;
using EstornoSaldoCarteiraVirtual.Dominio.Entidades;
using EstornoSaldoCarteiraVirtual.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstornoSaldoCarteiraVirtual.Aplicacao.Servicos
{    
    public class ServicoAppEstornoCarteiraVirtual : ServicoAppBasico<EstornoCarteiraVirtual, EstornoCarteiraVirtualDto>, IAppEstornoCarteiraVirtual
    {
        public ServicoAppEstornoCarteiraVirtual(IMapper iMapper, IServicoEstornoCarteiraVirtual servico) : base(iMapper, servico)
        {

        }
    }
}
