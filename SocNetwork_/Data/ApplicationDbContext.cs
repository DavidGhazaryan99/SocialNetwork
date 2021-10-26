using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocNetwork_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocNetwork_.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.firstName)
                .HasMaxLength(250);
            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.lastName)
                .HasMaxLength(250);
            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.DateOfBirth)
                .HasMaxLength(250);
            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.ProfilePicture)
                .HasMaxLength(250);
        }
    }
}
