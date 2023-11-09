using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Items;

namespace Model.Entities.Heroes.Inventories; 

[Table("INVENTORY_HAS_ITEMS_JT")]
public class InventoryItem {

    [Column("INVENTORY_ID")]
    public int InventoryId { get; set; }
    public Inventory Inventory { get; set; }

    [Column("ITEM_ID")]
    public int ItemId { get; set; }
    public AItem Item { get; set; }
}