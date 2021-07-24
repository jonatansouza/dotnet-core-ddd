using Api.Data.Context;
using Api.Data.implementations;
using Api.Data.Repository;
using Api.Domain.interfaces;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();

            serviceCollection.AddDbContext<MyContext>(
                option => option.UseMySql("Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=adm123")
            );
        }
    }
}
