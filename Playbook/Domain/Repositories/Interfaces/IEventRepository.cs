using Model.Entities.Events;

namespace Domain.Repositories.Interfaces; 

public interface IEventRepository : IRepository<AEvent> {

    Task<List<AEvent>> GetEventsOfSectionAsync(int sectionId);
}