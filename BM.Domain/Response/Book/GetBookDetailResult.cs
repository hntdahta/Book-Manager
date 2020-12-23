using System;
using System.Collections.Generic;
using System.Text;

namespace BM.Domain.Response.Book
{
    public class GetBookDetailResult
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int YearReleased { get; set; }
        public int Stock { get; set; }
        public string CategoryName { get; set; }
    }
}
