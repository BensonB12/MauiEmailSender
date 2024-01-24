using BlazorApp1.Data;
using Microsoft.AspNetCore.Mvc;
using RazorClassLibrary1.Data;

namespace BlazorApp1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : Controller
{
    IFakeDbContext _context;
    public BookController(IFakeDbContext c)
    {
        _context = c;
    }

    [HttpGet("all")]
    public async Task<IEnumerable<Book>> GetAllBooks()
    {
        return await _context.GetAllBooks();
    }

    [HttpGet("new/{bookTitle}")]
    public async Task<IEnumerable<Book>> GetAllBooks(string bookTitle)
    {
        await _context.AddABook(new(bookTitle));
        return await _context.GetAllBooks();
    }
}
