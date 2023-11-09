using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configuration;
using Model.Entities.Sections.StorySections;

namespace Domain.Repositories.Implementation; 

public class StorySectionRepository : ARepository<StorySection>, IStorySectionRepository {
    public StorySectionRepository(PlaybookContext context) : base(context) {
    }

    public async Task<StorySection?> ReadStorySectionAsync(int bookId, int sectionNr) =>
        await Table
            .Where(t => t.BookId == bookId && t.SectionNumber == sectionNr)
            .Include(s=>s.Book)
            .Include(s=>s.Outcomes)
            .ThenInclude(o=>o.Section)
            .Include(s=>s.Events)
            .FirstOrDefaultAsync();
    
    public int GetFirstStorySectionId(int bookId) => 
        Table.SingleOrDefault(s => s.BookId == bookId && s.SectionNumber == 1)!.Id;
    
    public async Task<List<StorySection>> ReadAllStorySectionsOfBookAsync(int bookId) =>
        await Table
            .Where(s => s.BookId == bookId)
            .Include(s=>s.Outcomes)
            .ThenInclude(o=>o.Section)
            .OrderBy(s=>s.SectionNumber)
            .ToListAsync();
    
}