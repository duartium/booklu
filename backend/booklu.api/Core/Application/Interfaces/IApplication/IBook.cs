namespace booklu.api.Core.Application.Interfaces.IApplication
{
    public interface IBook
    {
        string Name { get; set; }
        string Description { get; set; }
        string Author { get; set; }
        string Title { get; set; }
        string Language { get; set; }
        decimal Price { get; set; }

    }
}
