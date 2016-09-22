using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ElectroStore.Models
{
    public class GoodContex : DbContext
    {
        public DbSet<Cabel> Cabels { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

    }
}