using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace AuthService2024032.Domain.Entities;
public class User
{
    [Key]
    [MaxLength(16)]
    public string Id {get; set;} = string.Empty;  

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [MaxLength(25, ErrorMessage = "El nombre no puede tener mas de 25 caracteres")]
    public string Name {get; set;} = string.Empty;  

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [MaxLength(25, ErrorMessage = "El nombre de apellido no puede tener mas de 25 caracteres")]
    public string Surname {get; set;} = string.Empty;  


    [Required(ErrorMessage = "El nombre es obligatorio")]
    [MaxLength(25, ErrorMessage = "El nombre de usuario no puede tener mas de 25 caracteres")]
    public string Username {get; set;} = string.Empty;  


    [Required(ErrorMessage = "El correo electronico es obligatorio")]
    [EmailAddress(ErrorMessage = "El correo electronico no tiene un formato valido")]
    [MaxLength(150, ErrorMessage = "El correo electronico no puede tener mas de 150 caracteres")]

    public string Email {get; set;} = string.Empty;


    [Required(ErrorMessage = "La contraseña es obligatoria")]
    [ MinLength(8, ErrorMessage = " La contraseña debe tener al meos 8 caracteres")]
    [MaxLength(255, ErrorMessage = " La contraseña no puede tener mas de 255 catacteres")]
    public string Password {get; set;} = string.Empty;

    public bool Status {get; set;} = false;

    public DateTime CreatedAt {get; set;}

    public DateTime UpdatedAt {get; set;}

    public UserProfile userProfile {get; set;} = null!;

    public ICollection<UserRole> userRoles { get; set;} = [];

    public UserEmail userEmail { get; set;} = null!;

    public UserPasswordReset userPasswordReset {get; set;} = null!;
}

