using Domain.Repositories.Interfaces;
using Model.Configuration;
using Model.Entities.Books;

namespace Domain.Repositories.Implementation; 

public class BookRepository : ARepository<Book>, IBookRepository {
    public BookRepository(PlaybookContext context) : base(context) {
    }
}