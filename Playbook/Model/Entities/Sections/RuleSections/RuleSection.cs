using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Sections.RuleSections; 

[Table("RULE_SECTIONS")]
public class RuleSection : ASection {
    
    [Required]
    [Column("SECTION_TYPE")]
    public ESectionType SectionType { get; set; }
}