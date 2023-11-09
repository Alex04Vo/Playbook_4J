using Model.Entities.Sessions;

namespace Domain.Repositories.Interfaces; 

public interface ISessionRepository : IRepository<Session> { 
    Task<List<Session>> ReadSessionsFromUserForOverview(int userId); 
    Task<bool> UserIsSessionOwner(int userId, int sessionId); 
    Task<Session?> ReadSession(int sessionId);
    Task<int[]?> GetCurrentBookIdAndCurrentSectionId(int sessionId);
}