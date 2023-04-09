using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Events.SubEvents.ItemEvents; 

[Table("ACQUIRE_ITEM_EVENTS")]
public class AcquireItemEvent : AItemEvent {
    
    public override string GetReadableType() {
        return "Acquire Item Event";
    }
}