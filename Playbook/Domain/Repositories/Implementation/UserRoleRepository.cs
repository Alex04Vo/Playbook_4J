using Domain.Repositories.Interfaces;
using Model.Configuration;
using Model.Entities.Users;

namespace Domain.Repositories.Implementation; 

public class UserRoleRepository : ARepository<UserRole>, IUserRoleRepository {
    public UserRoleRepository(PlaybookContext context) : base(context) {
    }
}