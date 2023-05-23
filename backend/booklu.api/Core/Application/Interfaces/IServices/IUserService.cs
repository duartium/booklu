using booklu.api.Core.Domain.Models;

namespace booklu.api.Core.Application.Interfaces.IServices
{
    public interface IUserService
    {
        AuthenticatedUser GetByAuth(UserLogin userLogin);
    }
}
