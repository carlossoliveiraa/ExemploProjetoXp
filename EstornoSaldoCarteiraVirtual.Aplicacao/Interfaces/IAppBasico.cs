using EstornoSaldoCarteiraVirtual.Aplicacao.Dto;
using EstornoSaldoCarteiraVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstornoSaldoCarteiraVirtual.Aplicacao.Interfaces
{
    public interface IAppBasico<TEntidade, TEntidadeDto> where TEntidade : EntidadeBasica
                                                         where TEntidadeDto : DtoBasico
    {
        long Incluir(TEntidade entidade);
        bool Alterar(TEntidade entidade);
        bool Apagar(long id);
        TEntidade SelecionarPorId(long id);
        IEnumerable<TEntidade> SelecionarTodos();
    }
}
