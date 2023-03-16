using Model.Entities.Sessions;

namespace Domain.Repositories.Interfaces; 

public interface IPlayedBookRepository : IRepository<PlayedBook> {
    Task UpdatePlayTimestamp(int sessionId, int bookId);
}