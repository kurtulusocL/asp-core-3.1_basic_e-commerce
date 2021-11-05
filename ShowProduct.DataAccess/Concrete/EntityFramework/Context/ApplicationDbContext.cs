using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShowProduct.Core.CrossCuttingConcert.Identities.MicrosoftIdentity;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.DataAccess.Concrete.EntityFramework.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ShowProduct;user Id=sa;Password=123");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<SendMail> SendMails { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }
        public DbSet<VideoAd> VideoAds { get; set; }
    }
}
