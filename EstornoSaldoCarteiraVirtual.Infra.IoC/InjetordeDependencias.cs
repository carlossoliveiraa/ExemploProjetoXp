using EstornoSaldoCarteiraVirtual.Aplicacao.Interfaces;
using EstornoSaldoCarteiraVirtual.Aplicacao.Servicos;
using EstornoSaldoCarteiraVirtual.Dominio.Interfaces.Repositorio;
using EstornoSaldoCarteiraVirtual.Dominio.Interfaces.Servicos;
using EstornoSaldoCarteiraVirtual.Dominio.Servicos;
using EstornoSaldoCarteiraVirtual.Infra.Dados.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EstornoSaldoCarteiraVirtual.Infra.IoC
{
    public class InjetordeDependencias
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            // Aplicação
            svcCollection.AddScoped(typeof(IAppBasico<,>), typeof(ServicoAppBasico<,>));
            svcCollection.AddScoped<IAppEstornoCarteiraVirtual, ServicoAppEstornoCarteiraVirtual>();           

            // Domínio
            svcCollection.AddScoped(typeof(IServicoBasico<>), typeof(ServicoBasico<>));
            svcCollection.AddScoped<IServicoEstornoCarteiraVirtual, ServicoEstornoCarteiraVirtual>();         

            // Repositorio
            svcCollection.AddScoped(typeof(IRepositorioBasico<>), typeof(RepositorioBasico<>));
            svcCollection.AddScoped<IRepositorioEstornoCarteiraVirtual, RepositorioEstornoCarteiraVirtual>();         

        }
    }
}
