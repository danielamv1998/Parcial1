using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1_DanielaMelendres.Models
{
    public class Producto
    {
        [Key]
        [StringLength(99999, MinimumLength = 1, ErrorMessage = "Ingrese entre 1 a 99999 numeros")]
        public int ProductId { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 30, ErrorMessage = "Ingrese entre 3 a 30 caracteres")]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        public string Price { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string LastBuy { get; set; }
       
    }
    
}
         
    
