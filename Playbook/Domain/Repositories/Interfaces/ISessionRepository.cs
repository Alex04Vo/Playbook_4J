using Model.Entities.Sessions;

namespace Domain.Repositories.Interfaces; 

public interface ISessionRepository {
    public Task<List<Session>> ReadSessionsFromUserForOverview(int userId);
}