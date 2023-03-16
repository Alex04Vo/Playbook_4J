using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configuration;
using Model.Entities.Sections.StorySections;
using Model.Entities.Sessions;
using MudBlazor.Extensions;

namespace Domain.Repositories.Implementation;

public class SessionRepository : ARepository<Session>, ISessionRepository {
    public SessionRepository(PlaybookContext context) : base(context) {
    }

    public async Task<List<Session>> ReadSessionsFromUserForOverview(int userId) {
        List<Session> list = await Table.Where(s => s.UserId == userId)
            .Include(s => s.Hero)
            .Include(s => s.BooksPlaying)
            .ThenInclude(b => b.Book)
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

    public async Task<bool> UserIsSessionOwner(int userId, int sessionId) =>
        await Table.AnyAsync(s => s.UserId == userId && s.Id == sessionId);

    public async Task<Session?> ReadSession(int sessionId) =>
        await Table.Where(s => s.Id == sessionId)
            .Include(s => s.Hero)
            .Include(s=>s.Hero.Abilities)
            .Include(s=>s.Hero.HeroOwnership)
            .Include(s=>s.Hero.Inventory)
            .ThenInclude(i=>i.Items)
            .ThenInclude(i=>i.Item)
            .SingleOrDefaultAsync();

    public async Task<int[]?> GetCurrentBookIdAndCurrentSectionId(int sessionId) {
        var result = new int[2];
        var session = await Table.Where(s => s.Id == sessionId)
            .Include(s=>s.BooksPlaying)
            .ThenInclude(b=>b.Sections)
            .ThenInclude(s=>s.Section)
            .SingleOrDefaultAsync();

        if (session is null) return null;

        var book = session.BooksPlaying.MaxBy(b => b.LastTimePlayed);
        if (book is null) return null;
        result[0] = book.BookId;
        if (!book.Sections.Any()) return null;
        var section = book.Sections.MaxBy(s => s.Timestamp)!.Section;
        result[1] = section.SectionNumber;
        return result;
    }
        
}