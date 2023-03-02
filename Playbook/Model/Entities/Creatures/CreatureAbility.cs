using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Abilities;

namespace Model.Entities.Creatures; 

[Table("CREATURE_HAS_ABILITIES_JT")]
public class CreatureAbility {
    [Column("CREATURE_ID")]
    public int CreatureId { get; set; }
    public Creature Creature { get; set; }

    [Column("ABILITY_TYPE")]
    public EAbilityType AbilityType { get; set; }
    public Ability Ability { get; set; }
}