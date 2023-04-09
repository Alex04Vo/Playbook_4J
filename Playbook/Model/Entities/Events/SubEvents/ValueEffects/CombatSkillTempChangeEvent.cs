using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Events.SubEvents.ValueEffects; 

[Table("COMBAT_SKILL_TEMPORARY_CHANGE_EVENTS")]
public class CombatSkillTempChangeEvent : AValueEvent {
    
    public override string GetReadableType() {
        return "Temporary Combat Skill Change";
    }
}