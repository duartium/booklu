using booklu.api.Application.Interfaces.IRepositories;
using booklu.api.Application.Interfaces.IServices;
using booklu.api.Core.Domain.Models;

namespace booklu.api.Infraestructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _rpsUser;
        public UserService(IUserRepository userRepository)
        {
            _rpsUser = userRepository;
        }
        public AuthenticatedUser GetByAuth(UserLogin userLogin)
        {
            throw new NotImplementedException();
        }
    }
}
