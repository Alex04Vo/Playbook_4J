using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Creatures; 

[Table("CREATURES")]
public class Creature {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("CREATURE_ID")]
    public int Id { get; set; }

    [Required, StringLength(50)]
    [Column("CREATURE_TYPE")]
    public string Type { get; set; }

    [Required, Range(0,50)]
    [Column("COMBAT_SKILL")]
    public int CombatSkill { get; set; }
    
    [Required,  Range(0,50)]
    [Column("ENDURANCE")]
    public int Endurance { get; set; }

    [Required, StringLength(100)]
    [Column("IMAGE_URL")]
    public string ImageUrl { get; set; }
    
    
}