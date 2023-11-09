using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configuration;
using Model.Entities.Sections.RuleSections;

namespace Domain.Repositories.Implementation;

public class RuleSectionRepository : ARepository<RuleSection>, IRuleSectionRepository {
    public RuleSectionRepository(PlaybookContext context) : base(context) {
    }

    public async Task<RuleSection?> GetTitlePageOfBook(int bookId) {
        return await Table
            .Where(s => s.BookId == bookId && s.SectionType == ESectionType.TITLE_PAGE)
            .SingleOrDefaultAsync();
    }
    
    public async Task<List<RuleSection>> GetRuleSectionsOfBook(int bookId) {
        return await Table
            .Where(s => s.BookId == bookId)
            .ToListAsync();
    }
}