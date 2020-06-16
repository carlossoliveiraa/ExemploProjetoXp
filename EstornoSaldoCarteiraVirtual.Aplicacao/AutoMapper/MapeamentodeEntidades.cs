using AutoMapper;
using EstornoSaldoCarteiraVirtual.Aplicacao.Dto;
using EstornoSaldoCarteiraVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstornoSaldoCarteiraVirtual.Aplicacao.AutoMapper
{
    public class MapeamentodeEntidades : Profile
    {
        public MapeamentodeEntidades()
        {
            this.CreateMap<EstornoCarteiraVirtual, EstornoCarteiraVirtualDto>().ReverseMap();             
        }
    }
}
