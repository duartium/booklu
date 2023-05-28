using booklu.api.Core.Application.Enums;
using booklu.api.Core.Application.Interfaces.IApplication;

namespace booklu.api.Infraestructure.Books
{
    public class BookFactory
    {
        public IBook CreateBook(BookType bookType)
        {
            switch (bookType)
            {
                case BookType.Bussiness:
                    return new BussinessBook();
                case BookType.History:
                    return new HistoryBook();
                case BookType.Philosophy:
                    return new PhilosophyBook();
                default:
                    throw new ArgumentException("Invalid book type", nameof(bookType));
            }
        }

    }
}
