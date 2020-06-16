using AutoMapper;
using EstornoSaldoCarteiraVirtual.Aplicacao.AutoMapper;
using EstornoSaldoCarteiraVirtual.Infra.Dados.Contexto;
using EstornoSaldoCarteiraVirtual.Infra.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace EstornoSaldoCarteiraVirtual.Servico.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
         
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ContextoEF>(o => o.UseSqlServer(this.Configuration.GetConnectionString("StrEstapar")));
            InjetordeDependencias.Registrar(services);

            services.AddAutoMapper(x => x.AddProfile(new MapeamentodeEntidades()), typeof(MapeamentodeEntidades));

            services.AddCors(opt =>
            {
                opt.AddDefaultPolicy(bldr =>
                {
                    bldr
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });

            services.AddControllers();

            services.AddSwaggerGen(c => {

                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Api Estapar",
                        Version = "v1",
                        Description = "Api de Integracao Estorno de Carteira Virtual"

                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();
            app.UseCors();

            app.UseRouting();

            app.UseAuthorization();

            //localhost:44350/swagger/index.html

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Estorno de Carteira Virtual");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
