using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Events.SubEvents.ValueEffects; 

[Table("RATION_AMOUNT_CHANGE_EVENTS")]
public class RationAmountEvent : AValueEvent {
    
    public override string GetReadableType() {
        return "Ration Amount Change";
    }
}