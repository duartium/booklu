namespace booklu.api.Core.Application.Interfaces.IApplication
{
    public interface IDatabase
    {
        string Name { get; }
        string StringConnection { get; }
        int Port { get; }
    }
}
