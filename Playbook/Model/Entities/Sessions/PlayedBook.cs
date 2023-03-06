using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Books;
using Model.Entities.Sections;

namespace Model.Entities.Sessions; 

[Table("SESSION_HAS_BOOKS_JT")]
public class PlayedBook {
    
    [Column("SECTION_ID")]
    public int SessionId { get; set; }
    public Session Session { get; set; }

    [Column("BOOK_ID")]
    public int BookId { get; set; }
    public Book Book { get; set; }

    [Column("CURRENT_SECTION_ID")]
    public int CurrentSectionId { get; set; }
    public ASection CurrentSection { get; set; }
    
    [Required, DataType(DataType.Date)]
    [Column("LAST_TIME_PLAYED")]
    public DateTime LastTimePlayed { get; set; }
}