﻿using _16125296_OnlineStore.Models;
using System.Data.Entity;

namespace _16125296_OnlineStore.OSDB
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}