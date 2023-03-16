using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configuration;
using Model.Entities.Sessions;

namespace Domain.Repositories.Implementation; 

public class PlayedBookRepository : ARepository<PlayedBook>, IPlayedBookRepository {
    public PlayedBookRepository(PlaybookContext context) : base(context) {
    }

    public async Task UpdatePlayTimestamp(int sessionId, int bookId) {
        var pBook = await Table.SingleOrDefaultAsync(p => p.SessionId == sessionId && p.BookId == bookId);
        if (pBook is not null) {
            pBook.LastTimePlayed = DateTime.Now;
            await UpdateAsync(pBook);
        }
    }
}