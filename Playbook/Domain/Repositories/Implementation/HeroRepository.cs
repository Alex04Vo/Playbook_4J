using Domain.Repositories.Interfaces;
using Model.Configuration;
using Model.Entities.Heroes;

namespace Domain.Repositories.Implementation; 

public class HeroRepository : ARepository<Hero>, IHeroRepository {
    public HeroRepository(PlaybookContext context) : base(context) {
    }
}