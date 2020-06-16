using EstornoSaldoCarteiraVirtual.Aplicacao.Dto;
using EstornoSaldoCarteiraVirtual.Aplicacao.Interfaces;
using EstornoSaldoCarteiraVirtual.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EstornoSaldoCarteiraVirtual.Servico.Api.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BaseController<TEntidade, TEntidadeDTO> : Controller where TEntidade : EntidadeBasica where TEntidadeDTO : DtoBasico
    {
        protected readonly IAppBasico<TEntidade, TEntidadeDTO> app;

        public BaseController(IAppBasico<TEntidade, TEntidadeDTO> app)
        {
            this.app = app;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Listar()
        {
            try
            {
                var obj = this.app.SelecionarTodos();
                return new OkObjectResult(obj);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult SelecionarPorId(int id)
        {
            try
            {
                var obj = this.app.SelecionarPorId(id);
                return new OkObjectResult(obj);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Incluir([FromBody] TEntidade obj)
        {
            try
            {
                return new OkObjectResult(this.app.Incluir(obj));
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] TEntidade obj)
        {
            try
            {
                this.app.Alterar(obj);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                this.app.Apagar(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
    }

}
