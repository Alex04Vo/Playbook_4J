using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Sections; 

[Table("IMAGE_DECORATORS")]
public class ImageDecorator {
    [Key]
    [StringLength(100)]
    [Column("IMAGE_URL")]
    public string ImageUrl { get; set; }

    [Column("SECTION_ID")]
    public int SectionId { get; set; }
    public ASection Section { get; set; }
}