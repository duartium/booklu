using booklu.api.Infraestructure.Persistence;

namespace booklu.api.Application.Interfaces.IApplication
{
    public interface IDatabaseAdapter
    {
        string Name { get; }
        string StringConnection { get; }
        int Port { get; }

        Connection GetConnection();
    }
}
