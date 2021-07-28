using System;
using Api.Domain.Dtos.UF;

namespace Api.Domain.Dtos.Municipio
{
    public class MunicipioDtoCompleto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int codIBGE { get; set; }

        public Guid UfId { get; set; }

        public UfDto Uf { get; set; }
    }
}
