using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Creatures;

namespace Model.Entities.Events.SubEvents;

[Table("COMBAT_EVENTS")]
public class CombatEvent : AEvent {
    
    [Column("CREATURE_ID")] 
    public int CreatureId { get; set; }
    public Creature Creature { get; set; }
    
    public override string GetReadableType() {
        return "Combat Event";
    }
}