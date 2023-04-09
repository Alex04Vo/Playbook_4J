using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Events;
using Model.Entities.Outcomes;
using Model.Entities.Regions;

namespace Model.Entities.Sections.StorySections; 

[Table("STORY_SECTIONS")]
public class StorySection : ASection {
    
    [Required]
    [Column("SECTION_NR")]
    public int SectionNumber { get; set; }

    [Column("REGION_ID")]
    public int RegionId { get; set; }
    public ARegion Region { get; set; }

    [NotMapped]
    public List<AOutcome> Outcomes { get; set; } = new();
    
    [NotMapped]
    public List<AEvent> Events { get; set; } = new();
}