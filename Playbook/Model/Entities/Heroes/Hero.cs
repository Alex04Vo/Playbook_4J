using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Heroes.Inventories;
using Model.Entities.Heroes.PlayerLevels;
using Model.Entities.Sessions;

namespace Model.Entities.Heroes; 

[Table("HEROES")]
public class Hero {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("HERO_ID")]
    public int Id { get; set; }

    [Required, StringLength(100)]
    [Column("NAME")]
    public string Name { get; set; }

    [Required, Range(0,200)]
    [Column("ENDURANCE")]
    public int Endurance { get; set; }
    
    [Required, Range(0,200)]
    [Column("COMBAT_SKILL")]
    public int CombatSkill { get; set; }

    [Column("SESSION_ID")]
    public int SessionId { get; set; }
    public Session Session { get; set; }

    [Column("HERO_LEVEL")]
    public EPlayerLevel HeroLevelValue { get; set; }
    public PlayerLevel HeroLevel { get; set; }

    [Column("HERO_OWNERSHIP_ID")]
    public int HeroOwnershipId { get; set; }
    public HeroOwnership HeroOwnership { get; set; }

    [Column("INVENTORY_ID")]
    public int InventoryId { get; set; }
    public Inventory Inventory { get; set; }
}