using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Sections.RuleSections;
using Model.Entities.Sections.StorySections;

namespace Model.Entities.Outcomes; 

[Table("OUTCOMES_BT")]
public abstract class AOutcome {
    
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("OUTCOME_ID")]
    public int Id { get; set; }
    
    [Column("ROOT_SECTION_ID")]
    public int RootSectionId { get; set; }
    public StorySection RootSection { get; set; }
    
    [Column("SECTION_ID")]
    public int SectionId { get; set; }
    public StorySection Section { get; set; }

    [Required, DataType(DataType.Text)]
    [Column("CONTENT")]
    public string Content { get; set; }
}