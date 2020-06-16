using System;
using System.Collections.Generic;
using System.Text;

namespace EstornoSaldoCarteiraVirtual.Aplicacao.Dto
{
    public class EstornoCarteiraVirtualDto : DtoBasico
    {
        public decimal Valor { get; set; }
        public string Frotista { get; set; }
        public int Quantidade { get; set; }
        public int EmpresaFrotistaId { get; set; }
    }
}
