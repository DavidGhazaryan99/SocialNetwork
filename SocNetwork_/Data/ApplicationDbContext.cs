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
                .Property(e => e.Address)
                .HasMaxLength(250);

            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.Gender)
                .HasMaxLength(250);

            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.ProfilePicture)
                .HasMaxLength(250);

            modelBuilder.Entity<FriendRequest>()
                    .HasOne(m => m.friendTo)
                    .WithMany(t => t.FriendsTo)
                    .HasForeignKey(m => m.friendToId);

            modelBuilder.Entity<FriendRequest>()
                .HasOne(m => m.friendFrom)
                .WithMany(t => t.FriendsFrom)
                .HasForeignKey(m => m.friendFromId);

            //modelBuilder.Entity<Friends>()
            //        .HasOne(m => m.user)
            //        .WithMany(t => t.Friends)
            //        .HasForeignKey(m => m.userId);

            //modelBuilder.Entity<Friends>()
            //    .HasOne(m => m.friendUser)
            //    .WithMany(t => t.Friends)
            //    .HasForeignKey(m => m.friendUserId);
        }
        public DbSet<UserPictures> UserPictures { get; set; }
        public DbSet<FriendRequest> FriendsRequest { get; set; }
        public DbSet<Friends> Friends { get; set; }
        public DbSet<LikedUsers> LikedUsers { get; set; }
        public DbSet<CommentingUsers> CommentingUsers { get; set; }

    }
}
