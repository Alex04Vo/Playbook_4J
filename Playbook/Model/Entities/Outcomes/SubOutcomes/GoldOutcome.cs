using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Outcomes.SubOutcomes; 

[Table("GOLD_OUTCOMES")]
public class GoldOutcome : AOutcome {

    [Required]
    [Column("AMOUNT")]
    public int Amount { get; set; }
}