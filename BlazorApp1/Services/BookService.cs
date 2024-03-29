﻿using BlazorApp1.Data;
using RazorClassLibrary1.Data;
using RazorClassLibrary1.IServices;

namespace BlazorApp1.Services;

public class BookService : IBookService
{
    IFakeDbContext _context;
    public BookService(IFakeDbContext context)
    {
        _context = context;
    }

    public async Task AddNewBook(Book b)
    {
        await _context.AddABook(b);
    }

    public async Task<IEnumerable<Book>> GetAllBooksAsync()
    {
        return await _context.GetAllBooks();
    }
}
