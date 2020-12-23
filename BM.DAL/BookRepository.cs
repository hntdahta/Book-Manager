using BM.DAL.Interface;
using BM.Domain.Request.Book;
using BM.Domain.Response.Book;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace BM.DAL
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public async Task<CreateBookResult> CreateBook(CreateBookRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BookName", request.BookName);
                parameters.Add("@Author", request.Author);
                parameters.Add("@Description", request.Description);
                parameters.Add("@YearReleased", request.YearReleased);
                parameters.Add("@Stock", request.Stock);
                parameters.Add("@CategoryId", request.CategoryId);
                return await SqlMapper.QueryFirstOrDefaultAsync<CreateBookResult>(cnn: connect,
                                                    sql: "sp_CreateBook",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<DeleteBookResult> DeleteBook(DeleteBookRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BookId", request.BookId);
                return await SqlMapper.QueryFirstOrDefaultAsync<DeleteBookResult>(cnn: connect,
                                                    sql: "sp_DeleteBook",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<GetBookDetailResult> GetBookDetail(GetBookDetailRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BookId", request.BookId);
                return await SqlMapper.QueryFirstOrDefaultAsync<GetBookDetailResult>(cnn: connect,
                                                    sql: "sp_GetDetailBook",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Book>> Gets()
        {
            return await SqlMapper.QueryAsync<Book>(cnn: connect,
                                    sql: "sp_GetBooks",
                                    commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateBookResult> UpdateBook(UpdateBookRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BookId", request.BookId);
                parameters.Add("@BookName", request.BookName);
                parameters.Add("@Author", request.Author);
                parameters.Add("@Description", request.Description);
                parameters.Add("@YearReleased", request.YearReleased);
                parameters.Add("@Stock", request.Stock);
                parameters.Add("@CategoryId", request.CategoryId);
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateBookResult>(cnn: connect,
                                                    sql: "sp_UpdateBook",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;

            }
        }
    }
}
