using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Events.SubEvents.ValueEffects; 

[Table("GOLD_AMOUNT_CHANGE_EVENTS")]
public class GoldAmountEvent : AValueEvent {
 
    public override string GetReadableType() {
        return "Gold Amount Change";
    }
}