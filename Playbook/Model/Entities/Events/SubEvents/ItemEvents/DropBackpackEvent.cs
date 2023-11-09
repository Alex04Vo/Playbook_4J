using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Events.SubEvents.ItemEvents; 

[Table("DROP_BACKPACK_EVENTS")]
public class DropBackpackEvent : AItemEvent {
    public override string GetReadableType() {
        return "Drop Backpack Event";
    }
}