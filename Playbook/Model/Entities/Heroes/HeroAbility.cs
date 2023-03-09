using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Abilities;

namespace Model.Entities.Heroes; 

[Table("HERO_HAS_ABILITIES_JT")]
public class HeroAbility {
    
    [Column("HERO_ID")]
    public int HeroId { get; set; }
    public Hero Hero{ get; set; }

    [Column("ABILITY_TYPE")]
    public EAbilityType AbilityType { get; set; }
    public Ability Ability { get; set; }
}