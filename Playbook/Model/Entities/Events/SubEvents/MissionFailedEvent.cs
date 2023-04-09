using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Events.SubEvents; 

[Table("MISSION_FAILED_EVENTS")]
public class MissionFailedEvent : AEvent {
 
    public override string GetReadableType() {
        return "Mission Failed";
    }
}