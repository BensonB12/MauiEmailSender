using RazorClassLibrary1.Data;

namespace RazorClassLibrary1.IServices;

public interface IBookService
{
    Task<IEnumerable<Book>> GetAllBooksAsync();
}
