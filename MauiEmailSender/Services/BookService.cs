using RazorClassLibrary1.Data;
using RazorClassLibrary1.IServices;
using System.Net.Http.Json;

namespace MauiEmailSender.Services
{
    public class BookService : IBookService
    {
        HttpClient httpClient;
        public BookService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new("https://localhost:7142");
        }
        public async Task AddNewBook(Book b)
        {
            await httpClient.GetFromJsonAsync<IEnumerable<Book>>($"/api/book/new/{b.title}");
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Book>>($"/api/book/all");
        }
    }
}
