using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siri_Web_Application.Models
{
    public class ProductType
    {
        [Key]
        [Display(Name ="Código")]
        public int ProductTypeId { get; set; }
        [Display(Name ="Descripción")]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}