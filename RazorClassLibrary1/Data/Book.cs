using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary1.Data
{
    public class Book
    {
        public Book(string title)
        {
            this.title = title;
        }
        public string title { get; set; }
    }
}
