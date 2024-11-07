using booklu.api.Application.Interfaces.IRepositories;
using booklu.api.Core.Domain.Models;

namespace booklu.api.Infraestructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public AuthenticatedUser GetByAuth(string username, string password)
        {
            return new AuthenticatedUser
            {
                IdUser = 1,
                Username = "Pickle Rick",
                CreatedAt = "2023-05-23",
                ProfileId = 1
            };
        }
    }
}
