using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Parcial1_DanielaAraucoPadilla.Models
{
    public class DataContext : DbContext

    {
        public System.Data.Entity.DbSet<Parcial1_DanielaAraucoPadilla.Models.Currency> Currencies { get; set; }

        public System.Data.Entity.DbSet<Parcial1_DanielaAraucoPadilla.Models.Product> Products { get; set; }
    }
}