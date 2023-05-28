namespace booklu.api.Core.Application.Interfaces.IApplication
{
    public interface IBook
    {
        string Name { get; }
        string Description { get; }
        string Author { get; }
        string Title { get; }
        string Language { get; }
        decimal Price { get; }
    }
}
