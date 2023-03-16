using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BC = BCrypt.Net.BCrypt;

namespace Model.Entities.Users; 

[Table("USERS")]
public class User {
    
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("USER_ID")]
    public int Id { get; set; }

    [Required, StringLength(50)]
    [MinLength(5)]
    [Column("USER_NAME")]
    public string UserName { get; set; }

    [Required, DataType(DataType.Text)]
    [Column("PASSWORD")]
    public string PasswordHash { get; set; }
    
    [NotMapped]
    public string LoginPassword { get; set; } = null!;

    public List<UserRoleClaim> RoleClaims { get; set; } = new();

    [NotMapped] 
    public IEnumerable<string> PlainRoles => RoleClaims.Select(x => x.UserRole.Identifier);

    
    public User ClearSensitiveData() {
        // PasswordHash = null!;
        return this;
    }

    public static string HashPassword(string plainPassword) {
        var salt = BC.GenerateSalt(8);
        return BC.HashPassword(plainPassword, salt);
    }

    public static bool VerifyPassword(string plainPassword, string hashedPassword) {
        return BC.Verify(plainPassword, hashedPassword);
    }
}