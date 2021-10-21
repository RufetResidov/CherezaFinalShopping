using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class EcommerceContext:IdentityDbContext<BadamUser>
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        {

        }
        public DbSet<BackImageAbout> BackImageAbouts { get; set; }
        public DbSet<BackImageBlog> BackImageBlogs { get; set; }
        public DbSet<BackImageProduct> BackImageProducts { get; set; }
        public DbSet<BackImageWishCheck> BackImageWishChecks { get; set; }
        public DbSet<AboutSection2> AboutSection2s { get; set; }
        public DbSet<AboutSection3> AboutSection3s { get; set; }
        public DbSet<BackImageProduct> BackImages { get; set; }
        public DbSet<IndexSlider> IndexSliders { get; set; }
        public DbSet<SocialInfo> SocialInfos { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<ContactSection2> ContactSection2s { get; set; }
        public DbSet<ContactSection4> ContactSection4s { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogCategory> BlogCategory { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderHistory> OrderHistories { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<FaqPage> FaqPages { get; set; }
        public DbSet<BadamUser> BadamUsers { get; set; }
        public DbSet<Tag> myTags{ get; set; }
        public DbSet<ProductToTag> ProductToTags{ get; set; }
        public DbSet<ContactUserMessage> ContactUserMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<BadamUser>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
        }
    }
}
