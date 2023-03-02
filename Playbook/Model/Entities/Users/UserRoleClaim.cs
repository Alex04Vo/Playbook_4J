using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Users; 

[Table("USER_HAS_ROLES_JT")]
public class UserRoleClaim {
    
    [Column("USER_ID")] 
    public int UserId { get; set; }
    public User User { get; set; } = null!;

    [Column("ROLE_ID")] 
    public int RoleId { get; set; }
    public UserRole UserRole { get; set; } = null!;
}