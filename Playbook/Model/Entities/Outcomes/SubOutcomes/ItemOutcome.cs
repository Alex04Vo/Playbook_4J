using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Items;

namespace Model.Entities.Outcomes.SubOutcomes; 

[Table("ITEM_OUTCOMES")]
public class ItemOutcome : AOutcome {
    
    [Column("ITEM_ID")]
    public int ItemId { get; set; }
    public AItem Item{ get; set; }
}