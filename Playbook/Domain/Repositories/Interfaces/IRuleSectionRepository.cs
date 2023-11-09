using Model.Entities.Sections.RuleSections;

namespace Domain.Repositories.Interfaces; 

public interface IRuleSectionRepository : IRepository<RuleSection> { 
    Task<RuleSection?> GetTitlePageOfBook(int bookId);
    Task<List<RuleSection>> GetRuleSectionsOfBook(int bookId);
}