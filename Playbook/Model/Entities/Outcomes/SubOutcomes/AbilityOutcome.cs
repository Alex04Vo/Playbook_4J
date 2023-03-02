using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Abilities;

namespace Model.Entities.Outcomes.SubOutcomes; 

[Table("ABILITY_OUTCOMES")]
public class AbilityOutcome : AOutcome {
    
    [Column("ABILITY_TYPE")]
    public EAbilityType AbilityType { get; set; }
    public Ability Ability { get; set; }
}