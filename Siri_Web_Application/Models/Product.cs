using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Siri_Web_Application.Models
{
    public class Product
    {
        [Key]
        [Display(Name ="Código")]
        public int ProductId { get; set; }
        [Display(Name ="Url de la imagen")]
        [DataType(DataType.ImageUrl)]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string ProductImage { get; set; }
        [Display(Name ="Nombre")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string ProductName { get; set; }
        [Display(Name ="Descripción")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Description { get; set; }
        [Display(Name = "Tipo de producto")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int ProductTypeId { get; set; }
        [Display(Name = "Subasta")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int AuctionId { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
        public virtual Auction Auction { get; set; }
    }
}