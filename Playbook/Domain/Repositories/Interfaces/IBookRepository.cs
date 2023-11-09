using System.Linq.Expressions;
using Model.Entities.Books;
using Model.Entities.Books.Models;

namespace Domain.Repositories.Interfaces; 

public interface IBookRepository : IRepository<Book> {
    Task<List<Book>> ReadAllWithTitlePageAsync();
    Task<BookOverviewModel?> ReadCompleteBookOverviewAsync(int bookId);
}