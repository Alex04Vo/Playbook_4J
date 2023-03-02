using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Sections.StorySections;

namespace Model.Entities.Events; 

[Table("EVENTS_BT")]
public abstract class AEvent {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("EVENT_ID")]
    public int Id { get; set; }

    [Column("SECTION_ID")]
    public int SectionId { get; set; }
    public StorySection Section { get; set; }

    [Required]
    [Column("RANKING")]
    public int Ranking { get; set; }
}