using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary1.Data
{
    public class Book
    {
        public string title { get; set; }
        public Book(string title)
        {
            this.title = title;
        }

        public string ToJson()
        {
            return this.title;
        }

        public string ToCVS()
        {
            return this.title + ",";
        }
    }
}
