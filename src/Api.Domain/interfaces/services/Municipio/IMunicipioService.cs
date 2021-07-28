using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Municipio;

namespace Api.Domain.interfaces.services.Municipio
{
    public interface IMunicipioService
    {
        Task<IEnumerable<MunicipioDto>> GetAll();
        Task<MunicipioDto> Get(Guid id);
        Task<MunicipioDtoCompleto> GetCompleteById(Guid id);
        Task<MunicipioDtoCompleto> GetCompleteByIBGE(int codIBGE);
        Task<MunicipioDtoCreateResult> Post(MunicipioDtoCreate municipio);
        Task<MunicipioDtoUpdateResult> Put(MunicipioDtoUpdate municipio);
        Task<bool> Delete(Guid id);

    }
}
