using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Effects; 

[Table("EFFECTS_BT")]
public class Effect {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("EFFECT_ID")]
    public int Id { get; set; }
}