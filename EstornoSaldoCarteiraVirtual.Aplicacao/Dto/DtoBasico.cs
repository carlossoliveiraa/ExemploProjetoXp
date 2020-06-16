using System;
using System.Collections.Generic;
using System.Text;

namespace EstornoSaldoCarteiraVirtual.Aplicacao.Dto
{
    public class DtoBasico
    {
        public long Id { get; set; }
        public int GaragemId { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
