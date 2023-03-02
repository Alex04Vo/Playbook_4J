using Domain.Repositories.Interfaces;
using Model.Configuration;
using Model.Entities.Users;

namespace Domain.Repositories.Implementation; 

public class UserRoleClaimRepository : ARepository<UserRoleClaim>, IUserRoleClaimRepository {
    public UserRoleClaimRepository(PlaybookContext context) : base(context) {
    }
}