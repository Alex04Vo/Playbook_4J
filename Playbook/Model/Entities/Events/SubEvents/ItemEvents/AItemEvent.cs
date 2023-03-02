using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Items;

namespace Model.Entities.Events.SubEvents.ItemEvents; 

[Table("ITEM_EVENTS_BT")]
public class AItemEvent : AEvent {
    
    [Column("ITEM_ID")]
    public int ItemId { get; set; }
    public AItem Item { get; set; }
}