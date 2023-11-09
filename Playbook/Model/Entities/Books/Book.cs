using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Sections.RuleSections;

namespace Model.Entities.Books; 

[Table("BOOKS")]
public class Book {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("BOOK_ID")]
    public int Id { get; set; }

    [Required, StringLength(100)]
    [Column("TITLE")]
    public string Title { get; set; }
    
    [Required, StringLength(100)]
    [Column("IMAGE_URL")]
    public string ImageUrl { get; set; }

    [NotMapped] 
    public RuleSection? TitlePage { get; set; } = null!;
}