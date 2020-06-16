using AutoMapper;
using EstornoSaldoCarteiraVirtual.Aplicacao.Dto;
using EstornoSaldoCarteiraVirtual.Aplicacao.Interfaces;
using EstornoSaldoCarteiraVirtual.Dominio.Entidades;
using EstornoSaldoCarteiraVirtual.Dominio.Interfaces.Servicos;
using System.Collections.Generic;

namespace EstornoSaldoCarteiraVirtual.Aplicacao.Servicos
{
    public class ServicoAppBasico<TEntidade, TEntidadeDTO> : IAppBasico<TEntidade, TEntidadeDTO>
                                                            where TEntidade : EntidadeBasica
                                                            where TEntidadeDTO : DtoBasico
    {

        protected readonly IServicoBasico<TEntidade> servico;
        protected readonly IMapper iMapper;

        public ServicoAppBasico(IMapper iMapper, IServicoBasico<TEntidade> servico) : base()
        {
            this.iMapper = iMapper;
            this.servico = servico;
        }

        public bool Alterar(TEntidade entidade)
        {
            return this.servico.Alterar(this.iMapper.Map<TEntidade>(entidade));
        }

        public bool Apagar(long id)
        {
            return this.servico.Apagar(id);
        }

        public long Incluir(TEntidade entidade)
        {
            return this.servico.Incluir(this.iMapper.Map<TEntidade>(entidade));
        }

        public TEntidade SelecionarPorId(long id)
        {
            return this.iMapper.Map<TEntidade>(this.servico.SelecionarPorId(id));
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return this.iMapper.Map<IEnumerable<TEntidade>>(this.servico.SelecionarTodos());
        }
    }
}
