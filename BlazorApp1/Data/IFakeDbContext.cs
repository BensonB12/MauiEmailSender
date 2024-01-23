using RazorClassLibrary1.Data;

namespace BlazorApp1.Data
{
    public interface IFakeDbContext
    {
        public Task AddABook(Book b);
        public Task<IEnumerable<Book>> GetAllBooks();
    }
}
