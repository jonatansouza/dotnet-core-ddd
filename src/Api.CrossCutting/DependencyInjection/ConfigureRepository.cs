using System;
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
            serviceCollection.AddScoped<IUfRepository, UfImplementation>();
            serviceCollection.AddScoped<IMunicipioRepository, MunicipioImplementation>();
            serviceCollection.AddScoped<ICepRepository, CepImplementation>();

            if (Environment.GetEnvironmentVariable("DATABASE").ToLower() == "SQLSERVER".ToLower())
            {
                serviceCollection.AddDbContext<MyContext>(
                    option => option.UseSqlServer(Environment.GetEnvironmentVariable("DB_CONNECTION"))
                );
            }
            else
            {
                serviceCollection.AddDbContext<MyContext>(
                    option => option.UseMySql(Environment.GetEnvironmentVariable("DB_CONNECTION") ?? "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=adm123")
                );

            }

        }
    }
}
