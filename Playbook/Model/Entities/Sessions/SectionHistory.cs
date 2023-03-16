using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Sections;
using Model.Entities.Sections.StorySections;

namespace Model.Entities.Sessions; 

[Table("SB_HAS_SECTIONS_JT")]
public class SectionHistory {
    
    [Column("SESSION_ID")]
    public int SessionId { get; set; }
    [Column("BOOK_ID")]
    public int BookId { get; set; }
    public PlayedBook PlayedBook { get; set; }

    [Column("SECTION_ID")]
    public int SectionId { get; set; }
    public StorySection Section { get; set; }

    [Required, DataType(DataType.DateTime)]
    [Column("TIMESTAMP")]
    public DateTime Timestamp { get; set; }
}