using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Siri_Web_Application.Models
{
    public class Person
    {
        [Display(Name = "Código")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPerson { get; set; }
        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Name { get; set; }
        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string LastName { get; set; }

        [Display(Name = "Nombre de usuario")]
        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(450)]
        [Index("IX_Username", 1, IsUnique = true)]
        public string UserName { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.Password)]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[\\W]).{8,64})", ErrorMessage = "La contraseña no es segura, debe tener mínimo 8 caracteres, recuerde usar mayúsculas, minúsculas, números y simbolos")]
        public string Password { get; set; }

        public ICollection<Purchase> Purchases { get; set; }
        public ICollection<Offer> Offers { get; set; }

    }
}