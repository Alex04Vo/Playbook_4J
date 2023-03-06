using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Users;

namespace Model.Entities.Sessions; 

[Table("SESSIONS")]
public class Session {
    
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("SESSION_ID")]
    public int Id { get; set; }

    [Required, StringLength(60)]
    [Column("NAME")]
    public string Name { get; set; }

    [Required, DataType(DataType.Date)]
    [Column("CREATED_AT")]
    public DateTime CreatedAt { get; set; }

    [Column("USER_ID")]
    public int UserId { get; set; }
    public User User { get; set; }
}