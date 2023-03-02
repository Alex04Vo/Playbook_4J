using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Users; 

[Table("USER_ROLES")]
public class UserRole {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("USER_ROLE_ID")]
    public int Id { get; set; }


    [Required] 
    [Column("IDENTIFIER")] 
    public string Identifier { get; set; } = null!;


    [Column("DESCRIPTION")] 
    public string? Description { get; set; }

    public List<UserRoleClaim> RoleClaims { get; set; } = new();

    [NotMapped] 
    public IEnumerable<User> Users => RoleClaims.Select(rc => rc.User);
}