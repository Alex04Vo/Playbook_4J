using Domain.Exceptions;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configuration;
using Model.Entities.Users;
using Model.Entities.Users.Models;

namespace Domain.Repositories.Implementation; 

public class UserRepository : ARepository<User>, IUserRepository {
    public UserRepository(PlaybookContext context) : base(context) {
    }
    
    public async Task<User?> FindByUsernameAsync(string userName, CancellationToken ct = default) {
        var user = await Table
            .Include(u => u.RoleClaims)
            .ThenInclude(rc => rc.UserRole)
            .AsSplitQuery() // <--- this is the magic
            .FirstOrDefaultAsync(u => u.UserName == userName, ct);
        
        return user?.ClearSensitiveData();
    }

    public async Task<User?> AuthorizeAsync(int id, CancellationToken ct = default) {
        var user = await Table
            .Include(u => u.RoleClaims)
            .ThenInclude(rc => rc.UserRole)
            .AsSplitQuery() // <--- this is the magic
            .FirstOrDefaultAsync(u => u.Id == id, ct);
        return user?.ClearSensitiveData();
    }

    public async Task<User?> AuthorizeAsync(LoginModel model, CancellationToken ct = default) {
        var user = await Table
            .Include(u => u.RoleClaims)
            .ThenInclude(rc => rc.UserRole)
            .AsSplitQuery() // <--- this is the magic
            .FirstOrDefaultAsync(u => u.UserName == model.UserName, ct);

        if (user is null) return null;

        if (String.IsNullOrWhiteSpace(model.UserName) || String.IsNullOrWhiteSpace(model.Password)) return null!;
        
        if (!User.VerifyPassword(model.Password, user.PasswordHash)) return null!;

        return user.ClearSensitiveData();
    }
    
    public async Task UpdateInfoAsync(User user, CancellationToken ct = default) {
        // check if email is already taken
        var userNameExists = await Table.AnyAsync(u => u.UserName == user.UserName && u.Id != user.Id, ct);
        if (userNameExists) throw new DuplicateUserNameException();

        // update user
        await UpdateAsync(user);
    }
}