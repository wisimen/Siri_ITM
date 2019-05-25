using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Siri_Web_Application.Models
{
    public class Offer
    {
        [Key]
        [Display(Name = "Código")]
        public int OfferId { get; set; }
        [Display(Name = "Fecha de Oferta")]
        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.Date, ErrorMessage = "Formato incorrecto")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", NullDisplayText = "No hay fecha", ApplyFormatInEditMode = true)]
        public DateTime OfferDate { get; set; }
        [Display(Name = "Valor a ofertar")]
        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.Currency, ErrorMessage = "Formato incorrecto")]
        public double OfferValue { get; set; }
        [Display(Name = "Favorecida")]
        public bool Favored { get; set; }
        [Display(Name = "Confirmado")]
        public bool Confirmed { get; set; }
        [Display(Name = "Producto")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int ProductId { get; set; }
        [Display(Name = "Ofertante")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int BidderId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Person Bidder { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}