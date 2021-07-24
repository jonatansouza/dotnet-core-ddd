using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.interfaces;

namespace Api.Domain.Repository
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> FindByLogin(string email);
    }
}
