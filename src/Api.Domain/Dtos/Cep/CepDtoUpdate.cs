using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Cep
{
    public class CepDtoUpdate
    {

        [Required(ErrorMessage = "Required ID")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Required Cep")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Required Logradouro")]
        public string Logradouro { get; set; }

        public string Numero { get; set; }

        [Required(ErrorMessage = "Required Municipio id")]
        public Guid MunicipioId { get; set; }

    }
}
