using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Abilities;

namespace Model.Entities.Effects; 

[Table("ABILITY_HAS_EFFECTS_JT")]
public class AbilityEffect {
    [Column("ABILITY_TYPE")]
    public EAbilityType AbilityType { get; set; }
    public Ability Ability { get; set; }

    [Column("EFFECT_ID")]
    public int EffectId { get; set; }
    public Effect Effect { get; set; }
}