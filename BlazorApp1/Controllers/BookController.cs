using BlazorApp1.Data;
using Microsoft.AspNetCore.Mvc;
using RazorClassLibrary1.Data;
using RazorClassLibrary1.IServices;

namespace BlazorApp1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : Controller
{
    IBookService _service;
    public BookController(IBookService c) 
    {
        _service = c;
    }

    [HttpGet("all")]
    public async Task<IEnumerable<Book>> GetAllBooks()
    {
        return await _service.GetAllBooksAsync();
    }

    [HttpGet("new/{bookTitle}")]
    public async Task<IEnumerable<Book>> AddNewBook(string bookTitle)
    {
        await _service.AddNewBook(new(bookTitle));
        return await _service.GetAllBooksAsync();
    }
}
