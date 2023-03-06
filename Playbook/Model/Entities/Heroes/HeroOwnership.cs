using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Heroes; 

[Table("HERO_OWNERSHIPS")]
public class HeroOwnership {
    
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("HERO_OWNERSHIP_ID")]
    public int Id { get; set; }

    [Required, Range(0,10000)]
    [Column("GOLD_COINS")]
    public int GoldCoins { get; set; }

    [Required, Range(0,20)]
    [Column("RATIONS")]
    public int Rations { get; set; }
}