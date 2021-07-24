using System.Threading.Tasks;
using Api.Domain.Dtos;

namespace Api.Domain.interfaces.services.User
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto user);
    }
}
