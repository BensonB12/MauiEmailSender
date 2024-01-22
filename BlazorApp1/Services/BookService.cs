using RazorClassLibrary1.Data;
using RazorClassLibrary1.IServices;

namespace BlazorApp1.Services;

public class BookService : IBookService
{
    /*public BookService(IdbContext context)
    {
        
    }*/
    public Task<IEnumerable<Book>> GetAllBooksAsync()
    {
        throw new NotImplementedException();
    }
}
