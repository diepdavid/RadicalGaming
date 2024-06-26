﻿using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RadicalGaming.Model;

namespace RadicalGaming.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Team> Team { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "David", DisplayOrder = 1 },
                new Team { Id = 2, Name = "Charllie", DisplayOrder = 2 },
                new Team { Id = 3, Name = "Albin", DisplayOrder = 3 },
                new Team { Id = 4, Name = "Rickard", DisplayOrder = 4 }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "GamingMouse", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Keyboard", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Headset", DisplayOrder = 3 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Viper Gamingmouse",
                    Description = "Achieve the next level of absolute control with the Razer Viper 8KHz, " +
                                  "a ambidextrous e-sports mouse with a true 8000 Hz polling rate for the " +
                                  "fastest speed and lowest latency ever achieved.",
                    Price = 69,
                    CategoryId = 1,
                    ImageUrl = "\\images\\product\\a34bf477-5f34-46de-a3ed-bb7eb0b6b204.jpg"
                },
                new Product
                {
                    Id = 2,
                    Title = "BlackWidow V3 Keyboard",
                    Description = "Mechanical gaming keyboard with Chroma RGB (Digital multifunction wheel and" +
                                  " media keys, Ergonomic wrist rest) Black, Nordic/Swedish layout",
                    Price = 139,
                    CategoryId = 2,
                    ImageUrl = "\\images\\product\\ae3bf58b-cc03-4532-87d4-170261cc92ed.jpg"
                },
                new Product
                {
                    Id = 3,
                    Title = "Kraken X Headset",
                    Description = "Defeat all enemies with the Razer Kraken X Lite gaming headset. With lightweight" +
                                  " design, 7.1 surround sound, reliable microphone, and versatile compatibility, you " +
                                  "can take on any challenge.",
                    Price = 39,
                    CategoryId = 3,
                    ImageUrl = "\\images\\product\\d848c702-cb12-4baf-a2f4-c960aa58d427.jpg"
                }
            );
        }
    }
}
