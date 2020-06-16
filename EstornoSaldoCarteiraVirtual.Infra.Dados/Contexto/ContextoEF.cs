using EstornoSaldoCarteiraVirtual.Dominio.Entidades;
using EstornoSaldoCarteiraVirtual.Infra.Dados.Mapeamento;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Linq;

namespace EstornoSaldoCarteiraVirtual.Infra.Dados.Contexto
{
    public class ContextoEF : DbContext
    {
        public ContextoEF(DbContextOptions<ContextoEF> options)
            : base(options)
        {
            if (this.Database.GetPendingMigrations().Count() > 0)
            {
                this.Database.Migrate();
            }
        }

        public IDbContextTransaction Transaction { get; private set; }
        public virtual DbSet<EstornoCarteiraVirtual> EstornoCarteiraVirtuals { get; set; }
        
        public IDbContextTransaction InitTransacao()
        {
            if (this.Transaction == null)
            {
                this.Transaction = this.Database.BeginTransaction();
            }

            return this.Transaction;
        }

        public void SendChanges()
        {
            this.Salvar();
            this.Commit();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EstornoCarteiraVirtualMap());     
        }

        private void RollBack()
        {
            if (this.Transaction != null)
            {
                this.Transaction.Rollback();
            }
        }

        private void Salvar()
        {
            try
            {
                this.ChangeTracker.DetectChanges();
                this.SaveChanges();
            }
            catch (Exception ex)
            {
                this.RollBack();
                throw new Exception(ex.Message);
            }
        }

        private void Commit()
        {
            if (this.Transaction != null)
            {
                this.Transaction.Commit();
                this.Transaction.Dispose();
                this.Transaction = null;
            }
        }
    }
}
