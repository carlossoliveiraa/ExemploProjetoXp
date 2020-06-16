using EstornoSaldoCarteiraVirtual.Dominio.Entidades;
using EstornoSaldoCarteiraVirtual.Dominio.Interfaces.Repositorio;
using EstornoSaldoCarteiraVirtual.Dominio.Interfaces.Servicos;

namespace EstornoSaldoCarteiraVirtual.Dominio.Servicos
{
    public class ServicoEstornoCarteiraVirtual : ServicoBasico<EstornoCarteiraVirtual>, IServicoEstornoCarteiraVirtual
    {
        public ServicoEstornoCarteiraVirtual(IRepositorioEstornoCarteiraVirtual repositorio) : base(repositorio)
        {

        }
    }
}
