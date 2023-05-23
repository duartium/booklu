using booklu.api.Core.Domain.Models;

namespace booklu.api.Core.Application.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        AuthenticatedUser GetByAuth(string username, string password);
    }
}
