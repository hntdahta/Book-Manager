using BM.Domain.Request.Book;
using BM.Domain.Response.Book;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BM.DAL.Interface
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Gets();
        Task<GetBookDetailResult> GetBookDetail(GetBookDetailRequest request);
        Task<CreateBookResult> CreateBook(CreateBookRequest request);
        Task<UpdateBookResult> UpdateBook(UpdateBookRequest request);
        Task<DeleteBookResult> DeleteBook(DeleteBookRequest request);
    }
}
