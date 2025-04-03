using Exercice04.Data;
using Microsoft.EntityFrameworkCore;

namespace Exercice04.Extensions
{
    public static class MyExtensions
    {
        public static void AddDependencies(this IServiceCollection serviceProvider) 
        {
            var dbHostname =  Environment.GetEnvironmentVariable("DB_HOST") ?? "localhost";
            var dbName = Environment.GetEnvironmentVariable("DB_NAME") ?? "testdb";
            var dbUser = Environment.GetEnvironmentVariable("DB_USER") ?? "root";
            var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "password";

            var connectionString = $"Server=tcp:{dbHostname},1433;Initial Catalog={dbName};Persist Security Info=False;User ID={dbUser};Password={dbPassword};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            serviceProvider.AddDbContext<ApplicationDbContext>(options
                => options.UseSqlServer(connectionString)
            );
        }
    }
}
