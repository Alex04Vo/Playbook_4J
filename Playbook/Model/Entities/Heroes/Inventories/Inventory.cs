using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Heroes.Inventories; 

[Table("INVENTORIES")]
public class Inventory {
    
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("INVENTORY_ID")]
    public int Id { get; set; }

    [Required, StringLength(100)]
    [Column("INVENTORY_STATE")]
    public EInventoryState InventoryState { get; set; } = EInventoryState.IN_ORDER;
    
}