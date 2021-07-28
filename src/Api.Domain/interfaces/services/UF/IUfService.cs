using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.UF;

namespace Api.Domain.interfaces.services.UF
{
    public interface IUfService
    {
        Task<UfDto> GetTask(Guid id);

        Task<IEnumerable<UfDto>> GetAll();
    }
}
