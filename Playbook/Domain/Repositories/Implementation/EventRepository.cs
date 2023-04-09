using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configuration;
using Model.Entities.Events;
using Model.Entities.Events.SubEvents;
using Model.Entities.Events.SubEvents.ItemEvents;

namespace Domain.Repositories.Implementation;

public class EventRepository : ARepository<AEvent>, IEventRepository {
    private readonly ICreatureRepository _creatureRepository;
    private readonly IItemRepository _itemRepository;

    public EventRepository(PlaybookContext context,
        ICreatureRepository creatureRepository, IItemRepository itemRepository) : base(context) {
        _creatureRepository = creatureRepository;
        _itemRepository = itemRepository;
    }

    public async Task<List<AEvent>> GetEventsOfSectionAsync(int sectionId) {
        List<AEvent> events = await Table.Where(e => e.SectionId == sectionId)
            .OrderBy(e => e.Ranking)
            .ToListAsync();

        for (int i = 0; i < events.Count; i++) {
            switch (events[i].GetType().Name) {
                case "CombatEvent":
                    events[i] = await LoadCreature(events[i]);
                    break;
                case "AcquireItemEvent":
                    events[i] = await LoadItem(events[i]);
                    break;
                case "DropItemEvent":
                    events[i] = await LoadItem(events[i]);
                    break;
                case "DropBackpackEvent":
                    events[i] = await LoadItem(events[i]);
                    break;
            }
        }

        return events;
    }

    private async Task<CombatEvent> LoadCreature(AEvent e) {
        var combatEvent = (CombatEvent) e;
        var creature = await _creatureRepository.ReadAsync(combatEvent.CreatureId);
        if (creature is not null) {
            combatEvent.Creature = creature;
        }

        return combatEvent;
    }

    private async Task<AItemEvent> LoadItem(AEvent e) {
        var itemEvent = (AItemEvent) e;
        var item = await _itemRepository.ReadAsync(itemEvent.ItemId);
        if (item is not null) {
            itemEvent.Item = item;
        }

        return itemEvent;
    }
}