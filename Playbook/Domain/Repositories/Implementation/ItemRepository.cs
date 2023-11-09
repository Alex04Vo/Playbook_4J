using Domain.Repositories.Interfaces;
using Model.Configuration;
using Model.Entities.Items;

namespace Domain.Repositories.Implementation; 

public class ItemRepository : ARepository<AItem>, IItemRepository {
    public ItemRepository(PlaybookContext context) : base(context) {
    }
}