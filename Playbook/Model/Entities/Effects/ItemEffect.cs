using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;
using Model.Entities.Items;

namespace Model.Entities.Effects; 

[Table("ITEM_HAS_EFFECTS_JT")]
public class ItemEffect {
    [Column("ITEM_ID")]
    public int ItemId { get; set; }
    public AItem Item { get; set; }

    [Column("EFFECT_ID")]
    public int EffectId { get; set; }
    public Effect Effect { get; set; }
}