namespace booklu.api.Core.Application.Interfaces
{
    public interface IBuilder<T> where T : class
    {
        T Build();
    }
}
