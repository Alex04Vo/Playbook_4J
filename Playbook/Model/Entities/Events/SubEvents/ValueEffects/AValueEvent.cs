using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Events.SubEvents.ValueEffects; 

[Table("CHANGE_VALUE_EVENTS_BT")]
public class AValueEvent : AEvent {
    [Required]
    [Column("AMOUNT")]
    public int Amount { get; set; }

    public override string GetReadableType() {
        return this.GetType().Name;
    }
}