using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configuration;
using Model.Entities.Sessions;

namespace Domain.Repositories.Implementation;

public class SessionRepository : ARepository<Session>, ISessionRepository {
    public SessionRepository(PlaybookContext context) : base(context) {
    }

    public async Task<List<Session>> ReadSessionsFromUserForOverview(int userId) {
        List<Session> list = await Table.Where(s => s.UserId == userId)
                .Include(s => s.Hero)
                .Include(s => s.BooksPlaying)
                .ThenInclude(b=>b.Book)
                .AsSplitQuery()
                .ToListAsync();

        foreach (var element in list) {
            if (element.BooksPlaying.Any()) {
                list.ForEach(s => {
                    s.BooksPlaying = s.BooksPlaying.OrderByDescending(b => b.LastTimePlayed).ToList();
                });
                list = list.OrderByDescending(s => s.BooksPlaying.FirstOrDefault()!.LastTimePlayed).ToList();
            }
        }
        
        return list;
    }
}