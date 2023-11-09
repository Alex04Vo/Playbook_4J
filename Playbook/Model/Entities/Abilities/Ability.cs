using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;

namespace Model.Entities.Abilities; 

[Table("ABILITIES")]
public class Ability {
    [Key]
    [Column("ABILITY_TYPE")]
    public EAbilityType Type { get; set; }

    [Required, DataType(DataType.Text)]
    [Column("DESCRIPTION")]
    public string Description { get; set; }
    
    [Required, StringLength(100)]
    [Column("IMAGE_URL")]
    public string ImageUrl { get; set; }

    public string ToReadableType() {

        var text = this.Type.ToString().Replace('_', ' ').ToLower();
        return char.ToUpper(text[0]) + text.Substring(1);

    }
}