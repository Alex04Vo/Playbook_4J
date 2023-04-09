using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Events.SubEvents; 

[Table("MISSION_ACCOMPLISHED_EVENTS")]
public class MissionAccomplishedEvent : AEvent {
    
    
    public override string GetReadableType() {
        return "Mission Accomplished!";
    }
}