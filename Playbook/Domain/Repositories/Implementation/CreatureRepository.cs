using Domain.Repositories.Interfaces;
using Model.Configuration;
using Model.Entities.Creatures;

namespace Domain.Repositories.Implementation; 

public class CreatureRepository : ARepository<Creature>, ICreatureRepository {
    public CreatureRepository(PlaybookContext context) : base(context) {
    }
}