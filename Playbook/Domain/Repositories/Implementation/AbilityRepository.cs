using Domain.Repositories.Interfaces;
using Model.Configuration;
using Model.Entities.Abilities;

namespace Domain.Repositories.Implementation; 

public class AbilityRepository : ARepository<Ability>, IAbilityRepository {
    public AbilityRepository(PlaybookContext context) : base(context) {
    }
}