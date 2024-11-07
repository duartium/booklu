namespace booklu.api.Application.Interfaces
{
    public interface IBuilder<T> where T : class
    {
        T Build();
    }
}
