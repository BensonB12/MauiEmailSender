using Android.Icu.Util;
using RazorClassLibrary1.Data;
using RazorClassLibrary1.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Task AddNewBook(Book b)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            throw new NotImplementedException();
        }
    }
}
