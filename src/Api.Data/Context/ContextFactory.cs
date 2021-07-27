using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION") ?? "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=adm123";
            // var connectionString = "Server=.\\SQLEXPRESS2017;Database=dbAPI;User Id=sa;Password=adm123"; // SQL SERVER
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();

            if (Environment.GetEnvironmentVariable("DATABASE") != null && Environment.GetEnvironmentVariable("DATABASE").ToLower() == "SQLSERVER".ToLower())
            {

                optionsBuilder.UseSqlServer(connectionString);
            }
            else
            {

                optionsBuilder.UseMySql(connectionString); // for mysql
            }
            return new MyContext(optionsBuilder.Options);
        }
    }
}
