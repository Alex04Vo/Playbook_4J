using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Heroes.PlayerLevels; 

[Table("PLAYER_LEVELS")]
public class PlayerLevel {
    [Key]
    [Column("PLAYER_LEVEL")]
    public EPlayerLevel Level { get; set; }

    [Required]
    [Column("ABILITY_COUNT")]
    public int AbilityCount { get; set; }

    [Required]
    [StringLength(100)]
    [Column("IMAGE_URL")]
    public string ImageUrl { get; set; }
}