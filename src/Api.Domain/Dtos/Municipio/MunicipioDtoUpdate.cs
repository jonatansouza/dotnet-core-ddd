using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Municipio
{
    public class MunicipioDtoUpdate
    {

        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Codigo IBGE invalido")]
        public int codIBGE { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        public Guid UfId { get; set; }
    }
}
