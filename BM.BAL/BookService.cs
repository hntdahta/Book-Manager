using BM.BAL.Interface;
using BM.DAL.Interface;
using BM.Domain.Request.Book;
using BM.Domain.Response.Book;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BM.BAL
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public async Task<CreateBookResult> CreateBook(CreateBookRequest request)
        {
            return await bookRepository.CreateBook(request);
        }

        public async Task<DeleteBookResult> DeleteBook(DeleteBookRequest request)
        {
            return await bookRepository.DeleteBook(request);
        }

        public async Task<GetBookDetailResult> GetBookDetail(GetBookDetailRequest request)
        {
            return await bookRepository.GetBookDetail(request);
        }

        public async Task<IEnumerable<Book>> Gets()
        {
            return await bookRepository.Gets();
        }

        public async Task<UpdateBookResult> UpdateBook(UpdateBookRequest request)
        {
            return await bookRepository.UpdateBook(request);
        }
    }
}
