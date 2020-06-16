using EstornoSaldoCarteiraVirtual.Dominio.Entidades;
using EstornoSaldoCarteiraVirtual.Dominio.Interfaces.Repositorio;
using EstornoSaldoCarteiraVirtual.Dominio.Interfaces.Servicos;
using System.Collections.Generic;

namespace EstornoSaldoCarteiraVirtual.Dominio.Servicos
{
    public class ServicoBasico<TEntidade> : IServicoBasico<TEntidade> where TEntidade : EntidadeBasica
    {
        protected readonly IRepositorioBasico<TEntidade> repositorio;

        public ServicoBasico(IRepositorioBasico<TEntidade> repositorio)
        {
            this.repositorio = repositorio;
        }

        public bool Alterar(TEntidade entidade)
        {
            return this.repositorio.Alterar(entidade);
        }

        public bool Apagar(long id)
        {
            return this.repositorio.Apagar(id);
        }

        public long Incluir(TEntidade entidade)
        {
            return this.repositorio.Incluir(entidade);
        }

        public TEntidade SelecionarPorId(long id)
        {
            return this.repositorio.SelecionarPorId(id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return this.repositorio.SelecionarTodos();
        }
    }
}
