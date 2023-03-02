using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Effects; 

[Table("VALUE_CHANGE_EFFECTS_BT")]
public abstract class ValueEffect : Effect {
    [Required]
    [Column("AMOUNT")]
    public int Amount { get; set; }
    
    [Required]
    [Column("DURATION")]
    public int Duration { get; set; }
}