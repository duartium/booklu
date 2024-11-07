using booklu.api.Infraestructure.Repositories;
using booklu.api.Infraestructure.Services;
using booklu.api.Application.Interfaces.IRepositories;
using booklu.api.Application.Interfaces.IServices;
using booklu.api.Application.Cache.RecentlyViewedBooksCache;

namespace booklu.api.Infraestructure.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddBookluServices(this IServiceCollection bookluServices)
    {
        bookluServices.AddScoped<IUserService, UserService>();


        return bookluServices;
    }
    public static IServiceCollection AddBookluRepositories(this IServiceCollection repositoriesServices)
    {
        repositoriesServices.AddScoped<IUserRepository, UserRepository>();
        
        return repositoriesServices;
    }

    public static IServiceCollection AddBookluCustomCache(this IServiceCollection services)
    {
        services.AddScoped(typeof(CacheBooks<>));
        return services;
    }
}
