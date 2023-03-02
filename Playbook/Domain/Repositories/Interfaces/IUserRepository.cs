using Model.Entities.Users;
using Model.Entities.Users.Models;

namespace Domain.Repositories.Interfaces;

public interface IUserRepository : IRepository<User> {
    Task<User?> FindByUsernameAsync(string userName, CancellationToken ct = default);

    Task<User?> AuthorizeAsync(int id, CancellationToken ct = default);

    Task<User?> AuthorizeAsync(LoginModel model, CancellationToken ct = default);

    Task UpdateInfoAsync(User user, CancellationToken ct = default);
}