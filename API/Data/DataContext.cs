﻿using API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        { }
        /****/
        public DbSet<AppUser> Users { get; set; }
        
    }
}
