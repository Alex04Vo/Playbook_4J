using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Events.SubEvents; 

[Table("STORY_EVENTS")]
public class StoryEvent : AEvent {
    
    [Required, StringLength(255)]
    [Column("TITLE")]
    public string Title { get; set; }

    [Required, DataType(DataType.Text)]
    [Column("DESCRIPTION")]
    public string Description { get; set; }
    
    [Required, StringLength(100)]
    [Column("IMAGE_URL")]
    public string ImageUrl { get; set; }

    public override string GetReadableType() {
        return "Stroy Event";
    }
}