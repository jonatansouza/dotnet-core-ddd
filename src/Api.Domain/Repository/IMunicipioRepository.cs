using System;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.interfaces;

namespace Api.Domain.Repository
{
    public interface IMunicipioRepository : IRepository<MunicipioEntity>
    {
        Task<MunicipioEntity> getCompleteById(Guid id);
        Task<MunicipioEntity> getCompleteByIBGE(Guid codIBGE);
    }
}
