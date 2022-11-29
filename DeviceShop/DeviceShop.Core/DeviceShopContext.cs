using DeviceShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DeviceShop.Core
{
    public class DeviceShopContext : IdentityDbContext<User>
    {
        public DeviceShopContext(DbContextOptions<DeviceShopContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
            base.OnModelCreating(builder);
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryModel> CategoriesModel { get; set; }
        public DbSet<Colour> Colours { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Guarantee> Guarantees { get; set; }
    }
}