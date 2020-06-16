using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstornoSaldoCarteiraVirtual.Aplicacao.Dto;
using EstornoSaldoCarteiraVirtual.Aplicacao.Interfaces;
using EstornoSaldoCarteiraVirtual.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace EstornoSaldoCarteiraVirtual.Servico.Api.Controllers
{   

    public class EstornoCarteiraVirtualController : BaseController<EstornoCarteiraVirtual, EstornoCarteiraVirtualDto>
    {
        public EstornoCarteiraVirtualController(IAppEstornoCarteiraVirtual app) : base(app)
        {
        }
    }
}