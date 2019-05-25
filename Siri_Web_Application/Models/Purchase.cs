using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Siri_Web_Application.Models
{
    public class Purchase
    {
        [Key]
        [Display(Name = "Código")]
        public int PurchaseId { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Fecha de Compra")]
        [DataType(DataType.Date, ErrorMessage = "Formato incorrecto")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", NullDisplayText = "No hay fecha", ApplyFormatInEditMode = true)]
        public DateTime PurchaseDate { get; set; }
        [DataType(DataType.Currency, ErrorMessage = "Formato incorrecto")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public double Value { get; set; }
        [Display(Name = "Oferta")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int OfferId { get; set; }
        [Display(Name = "Comprador")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int PurchaserId { get; set; }
        [ForeignKey("PurchaserId")]
        public virtual Person Buyer { get; set; }
    }
}