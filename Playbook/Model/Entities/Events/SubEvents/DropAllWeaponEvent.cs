using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Events.SubEvents; 

[Table("DROP_ALL_WEAPONS_EVENTS")]
public class DropAllWeaponEvent : AEvent {
    
    public override string GetReadableType() {
        return "Drop All Weapon Event";
    }
}