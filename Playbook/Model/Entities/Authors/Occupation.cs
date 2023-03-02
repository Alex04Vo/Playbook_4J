using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Books;

namespace Model.Entities.Authors; 

[Table("BOOK_HAS_AUTHORS_JT")]
public class Occupation {
    
    [Column("BOOK_ID")]
    public int BookId { get; set; }
    public Book Book { get; set; }
    
    [Column("AUTHOR_ID")]
    public int AuthorId { get; set; }
    public Author Author { get; set; }

    [Required]
    [Column("OCCUPATION_TYPE")]
    public EOccupationType OccupationType { get; set; }
}