using RazorClassLibrary1;
using RazorClassLibrary1.Data;

namespace BlazorApp1.Data
{
    public class FakeDbContext : IFakeDbContext
    {
        List<Book> books { get; set; }

        public FakeDbContext() 
        { 
            books = new List<Book>();
            var cvs = File.ReadAllText(Utilities.FindFile("BookDataBase.json"));
            var values = cvs.Split(',');

            for(int i = 0; i < values.Length - 1; i++)
                books.Add(new(values[i]));
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            await Task.CompletedTask;
            return books;
        }

        public async Task AddABook(Book b)
        {
            await Task.CompletedTask;
            File.AppendText(b.ToCVS());
        }
    }
}
