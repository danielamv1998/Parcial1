using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial1_DanielaMelendres.Models
{
    public class DataCurrency : DbCurrency
    {
        public DataCurrency() : base("DefaultConnection")
        {

        }
        public System.Data.Entity.DbSet<apiProducto.Models.Prduct> People { get; set; }
    }
}
