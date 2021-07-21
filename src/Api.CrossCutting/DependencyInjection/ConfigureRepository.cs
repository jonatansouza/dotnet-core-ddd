using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddDbContext<MyContext>(
                option => option.UseMySql("Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=adm123")
            );
        }
    }
}
