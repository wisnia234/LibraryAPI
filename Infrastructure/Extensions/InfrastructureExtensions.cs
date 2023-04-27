using Microsoft.Extensions.Options;

namespace Infrastructure.Extensions;

public static class InfrastructureExtensions
{
    public static void AddInfrastructure(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddScoped<IBookService, BookService>();
        service.AddScoped<IBookRepository, BookRepository>();

        service.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("Database"));
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        });
    }
           

    
}
