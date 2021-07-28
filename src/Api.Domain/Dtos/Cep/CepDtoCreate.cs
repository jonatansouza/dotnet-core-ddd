using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Cep
{
    public class CepDtoCreate
    {
        [Required(ErrorMessage = "Required Cep")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Required Logradouro")]
        public string Logradouro { get; set; }

        public string Numero { get; set; }

        [Required(ErrorMessage = "Required Municipio id")]
        public Guid MunicipioId { get; set; }

    }
}
