using System.ComponentModel.DataAnnotations;

namespace AuthService2024032.Domain.Entities;
public class User
{
    [key]
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
}
}
