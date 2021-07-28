using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.interfaces;

namespace Api.Domain.Repository
{
    public interface ICepRepository : IRepository<CepEntity>
    {
        Task<CepEntity> SelectAsync(string cep);
    }
}
