using Domain.Repositories.Interfaces;
using Model.Configuration;
using Model.Entities.Sessions;

namespace Domain.Repositories.Implementation; 

public class SectionHistoryRepository : ARepository<SectionHistory>, ISectionHistoryRepository {
    public SectionHistoryRepository(PlaybookContext context) : base(context) {
    }
}