using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SnackStore.Data.Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackStore.Data.Context
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ApplicationUser> AppUsers { get; set; }
        public DbSet<Items> items { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Items>().HasData(new Items
            {
                Id = 1,
                Name = "Spring Roll",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://redmangoimages.blob.core.windows.net/redmango/spring roll.jpg",
                Price = 7.99,
                Category = "Appetizer",
                SpecialTag = ""
            }, new Items
            {
                Id = 2,
                Name = "Idli",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://redmangoimages.blob.core.windows.net/redmango/idli.jpg",
                Price = 8.99,
                Category = "Appetizer",
                SpecialTag = ""
            }, new Items
            {
                Id = 3,
                Name = "Panu Puri",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://redmangoimages.blob.core.windows.net/redmango/pani puri.jpg",
                Price = 8.99,
                Category = "Appetizer",
                SpecialTag = "Best Seller"
            }, new Items
            {
                Id = 4,
                Name = "Hakka Noodles",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://redmangoimages.blob.core.windows.net/redmango/hakka noodles.jpg",
                Price = 10.99,
                Category = "Entrée",
                SpecialTag = ""
            }, new Items
            {
                Id = 5,
                Name = "Malai Kofta",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://redmangoimages.blob.core.windows.net/redmango/malai kofta.jpg",
                Price = 12.99,
                Category = "Entrée",
                SpecialTag = "Top Rated"
            }, new Items
            {
                Id = 6,
                Name = "Paneer Pizza",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://redmangoimages.blob.core.windows.net/redmango/paneer pizza.jpg",
                Price = 11.99,
                Category = "Entrée",
                SpecialTag = ""
            }, new Items    
            {
                Id = 7,
                Name = "Paneer Tikka",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://redmangoimages.blob.core.windows.net/redmango/paneer tikka.jpg",
                Price = 13.99,
                Category = "Entrée",
                SpecialTag = "Chef's Special"
            }, new Items
            {
                Id = 8,
                Name = "Carrot Love",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://redmangoimages.blob.core.windows.net/redmango/carrot love.jpg",
                Price = 4.99,
                Category = "Dessert",
                SpecialTag = ""
            }, new Items
            {
                Id = 9,
                Name = "Rasmalai",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://redmangoimages.blob.core.windows.net/redmango/rasmalai.jpg",
                Price = 4.99,
                Category = "Dessert",
                SpecialTag = "Chef's Special"
            }, new Items
            {
                Id = 10,
                Name = "Sweet Rolls",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://redmangoimages.blob.core.windows.net/redmango/sweet rolls.jpg",
                Price = 3.99,
                Category = "Dessert",
                SpecialTag = "Top Rated"
            });
        }
    }
}
