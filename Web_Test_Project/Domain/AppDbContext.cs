using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Test_Project.Domain.Entities;

namespace Web_Test_Project.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "630a72aa-5575-4481-b471-343316c89e21",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "8e0701eb-1ba4-4d3a-aeb3-2150f8c79a8a",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "astriyonok@mail.ru",
                NormalizedEmail = "ASTRIYONOK@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password"),
                SecurityStamp = string.Empty

            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "630a72aa-5575-4481-b471-343316c89e21",
                UserId = "8e0701eb-1ba4-4d3a-aeb3-2150f8c79a8a"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                id = new Guid("6dacc048-c803-4dcb-9a4b-3c363bc98832"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                id = new Guid("6b7438db-fb58-4e5e-82aa-dcf6ed0539f8"),
                CodeWord = "PageServices",
                Title = "Наши услуги"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                id = new Guid("1846eb16-3872-4b82-af3b-08b78ed25166"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }
    }
}
