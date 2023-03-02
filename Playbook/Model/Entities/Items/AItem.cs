using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Items; 

[Table("ITEMS_ST")]
public abstract class AItem {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ITEM_ID")]
    public int Id { get; set; }

    [Required, StringLength(100)]
    [Column("NAME")]
    public string Name { get; set; }

    [Required, DataType(DataType.Text)]
    [Column("DESCRIPTION")]
    public string Description { get; set; }

    [Required]
    [Column("WEIGHT")]
    public EItemWeight Weight { get; set; }

    [Required, StringLength(100)]
    [Column("IMAGE_URL")]
    public string ImageUrl { get; set; }
}