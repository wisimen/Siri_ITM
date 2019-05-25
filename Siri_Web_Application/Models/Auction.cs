using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Siri_Web_Application.Models
{
    public class Auction
    {
        [Key]
        [Display(Name = "Código")]
        public int AuctionId { get; set; }

        [Display(Name = "Precio Base")]
        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.Currency, ErrorMessage = "Formato incorrecto")]
        public double BasePrice { get; set; }

        [Display(Name = "Ubicación")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Location { get; set; }

        [Display(Name = "Fecha de inicio")]
        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.Date, ErrorMessage = "Formato incorrecto")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", NullDisplayText = "No hay fecha", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }


        [Display(Name = "Fecha de Cierre")]
        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.Date, ErrorMessage = "Formato incorrecto")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", NullDisplayText = "No hay fecha", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Vendedor")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string SellerId { get; set; }

        [ForeignKey("SellerId")]
        public Person Seller { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}