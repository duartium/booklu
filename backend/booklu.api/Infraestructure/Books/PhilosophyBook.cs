using booklu.api.Application.Interfaces.IApplication;

namespace booklu.api.Infraestructure.Books
{
    public class PhilosophyBook : IBook
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public string Title { get; set; }

        public string Language { get; set; }

        public decimal Price { get; set; }
    }
}
