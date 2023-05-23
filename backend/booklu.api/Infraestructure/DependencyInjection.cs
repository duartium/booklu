using booklu.api.Core.Application.Interfaces.IServices;
using booklu.api.Core.Application.Services;
using booklu.api.Core.Application.Interfaces.IRepositories;

namespace booklu.api.Infraestructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBookluServices(this IServiceCollection bookluServices)
        {
            bookluServices.AddScoped<IUserService, UserService>();
            
            return bookluServices;
        }
        public static IServiceCollection AddBookluRepositories(this IServiceCollection repositoriesServices)
        {
            repositoriesServices.AddScoped<IUserRepository, IUserRepository>();
            
            return repositoriesServices;
        }
    }
}
