using System.ComponentModel.DataAnnotations;

namespace Model.Entities.Users.Models;

public class LoginModel {
    
    public LoginModel() {
    }

    public LoginModel(string userName, string password) {
        UserName = userName;
        Password = password;
    }

    [Required] 
    [EmailAddress] 
    public string UserName { get; set; } = null!;

    [Required] 
    public string Password { get; set; } = null!;
}