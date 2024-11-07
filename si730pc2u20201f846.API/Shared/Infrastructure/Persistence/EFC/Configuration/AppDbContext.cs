using Microsoft.EntityFrameworkCore;
using si730pc2u20201f846.API.Shared.Domain.Entities;
using si730pc2u20201f846.API.Shared.Infrastructure.Persistence.EFC.Configurations;

namespace si730pc2u20201f846.API.Shared.Infrastructure.Persistence.EFC
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(ToSnakeCase(entity.GetTableName()));
                foreach (var property in entity.GetProperties())
                {
                    property.SetColumnName(ToSnakeCase(property.Name));
                }
            }
        }
        private string ToSnakeCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            var stringBuilder = new System.Text.StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                var c = input[i];
                if (char.IsUpper(c) && i > 0)
                {
                    stringBuilder.Append('_');
                }
                stringBuilder.Append(char.ToLower(c));
            }
            return stringBuilder.ToString();
        }
    }
}
