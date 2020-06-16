using EstornoSaldoCarteiraVirtual.Dominio.Entidades;
using EstornoSaldoCarteiraVirtual.Dominio.Interfaces.Repositorio;
using EstornoSaldoCarteiraVirtual.Infra.Dados.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstornoSaldoCarteiraVirtual.Infra.Dados.Repositorio
{
    public class RepositorioBasico<TEntidade> : IRepositorioBasico<TEntidade> where TEntidade : EntidadeBasica
    {
        protected readonly ContextoEF contexto;

        public RepositorioBasico(ContextoEF contexto)
            : base()
        {
            this.contexto = contexto;
        }

        public bool Alterar(TEntidade entidade)
        {
            try
            {
                this.contexto.InitTransacao();
                this.contexto.Set<TEntidade>().Attach(entidade);
                this.contexto.Entry(entidade).State = EntityState.Modified;
                this.contexto.SendChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Apagar(long id)
        {
            try
            {
                var entidade = this.SelecionarPorId(id);
                if (entidade != null)
                {
                    this.contexto.InitTransacao();
                    this.contexto.Set<TEntidade>().Remove(entidade);
                    this.contexto.SendChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long Incluir(TEntidade entidade)
        {
            this.contexto.InitTransacao();
            var id = this.contexto.Set<TEntidade>().Add(entidade).Entity.Id;
            this.contexto.SendChanges();
            return id;
        }

        public TEntidade SelecionarPorId(long id)
        {
            return this.contexto.Set<TEntidade>().Find(id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return this.contexto.Set<TEntidade>().ToList();
        }
    }
}
