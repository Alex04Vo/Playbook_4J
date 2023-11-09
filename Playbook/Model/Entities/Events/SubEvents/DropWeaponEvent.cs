using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Events.SubEvents; 

[Table("DROP_WEAPON_EVENTS")]
public class DropWeaponEvent : AEvent {
   
    public override string GetReadableType() {
        return "Drop Weapon Event";
    }
}