using System.Text.Json;

namespace booklu.api.Application.Cache.RecentlyViewedBooksCache;

public class BookNode<T>
{
    public T Data { get; set; }
    public BookNode<T> Next { get; set; }

    public BookNode(T data)
    {
        Data = data;
        Next = null;
    }
}

/// <summary>
/// books cache like lifo linked list 
/// </summary>
public class CacheBooks<T>
{
    private BookNode<T> head;

    public void AddBook(T data)
    {
        var newBook = new BookNode<T>(data);
        newBook.Next = head;
        head = newBook;
    }

    public void RemoveBook(T data)
    {
        if (head == null) return;

        //when node is the first (head)
        if (head.Data.Equals(data))
        {
            head = head.Next;
            return;
        }

        //search node
        BookNode<T> current = head;
        while (current.Next != null
            && !current.Next.Data.Equals(data))
        {
            current = current.Next;
        }

        if (current.Next != null)
            current.Next = current.Next.Next;
    }

    public string GetAllElementsAsJson()
    {
        var elements = new List<T>();
        BookNode<T> current = head;

        while (current != null)
        {
            elements.Add(current.Data);
            current = current.Next;
        }

        return JsonSerializer.Serialize(
            elements,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });
    }
}
