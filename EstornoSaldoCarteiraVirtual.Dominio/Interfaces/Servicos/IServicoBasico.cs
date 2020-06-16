using EstornoSaldoCarteiraVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstornoSaldoCarteiraVirtual.Dominio.Interfaces.Servicos
{
    public interface IServicoBasico<TEntidade> where TEntidade : EntidadeBasica
    {
        long Incluir(TEntidade entidade);
        bool Alterar(TEntidade entidade);
        bool Apagar(long id);
        TEntidade SelecionarPorId(long id);
        IEnumerable<TEntidade> SelecionarTodos();
    }
}
