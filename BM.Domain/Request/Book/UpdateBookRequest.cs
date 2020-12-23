using System;
using System.Collections.Generic;
using System.Text;

namespace BM.Domain.Request.Book
{
    public class UpdateBookRequest
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int YearReleased { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
    }
}
