using booklu.api.Core.Domain.Models;

namespace booklu.api.Application.Interfaces.IServices
{
    public interface IUserService
    {
        AuthenticatedUser GetByAuth(UserLogin userLogin);
    }
}
