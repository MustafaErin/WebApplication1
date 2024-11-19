using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WebApplication1.Models.Dal.entities;

namespace WebApplication1.Models.Dal.Context
{
    public class PortfolyoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=DESKTOP-A2B47T0\\SQLEXPRESS01;database=PortfoltoProject;integrated security=true; TrustServerCertificate=True ");


         }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experiance> Experiances { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
    }

}
