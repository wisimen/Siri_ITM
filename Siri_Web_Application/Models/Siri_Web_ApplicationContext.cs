using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Siri_Web_Application.Models
{
    public class Siri_Web_ApplicationContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Siri_Web_ApplicationContext() : base("name=Siri_Web_ApplicationContext")
        {
        }

        public System.Data.Entity.DbSet<Siri_Web_Application.Models.Person> People { get; set; }

        public System.Data.Entity.DbSet<Siri_Web_Application.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<Siri_Web_Application.Models.Auction> Auctions { get; set; }

        public System.Data.Entity.DbSet<Siri_Web_Application.Models.ProductType> ProductTypes { get; set; }

        public System.Data.Entity.DbSet<Siri_Web_Application.Models.Offer> Offers { get; set; }

        public System.Data.Entity.DbSet<Siri_Web_Application.Models.Purchase> Purchases { get; set; }
    }
}
