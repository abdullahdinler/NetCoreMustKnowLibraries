﻿using FluentValidationApp.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace FluentValidationApp.Web.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
