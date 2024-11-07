using booklu.api.Core.Domain.Models;

namespace booklu.api.Application.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        AuthenticatedUser GetByAuth(string username, string password);
    }
}
