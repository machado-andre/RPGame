using Microsoft.EntityFrameworkCore;
using RPGame.Classes;

namespace RPGame
{
    public class RPGameDbContext : DbContext
    {
        public RPGameDbContext()
        {
        }

        public RPGameDbContext(DbContextOptions<RPGameDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Being> Beings { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Minion> Minions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().
                HasData(
                new Location { LocationId = 1, Name = "Home" });

            //modelBuilder.Entity<Minion>().
            //    HasData(
            //    new Minion { BeingId = 2, HP = 10, BaseDamage =1, Level = 3, Gold = 10, LocationId = 1, MinionType = MinionType.Rat, SkinColor = SkinColor.Black});

            modelBuilder.Entity<Player>()
                .HasData(
                new Player { BeingId = 1, HP = 10, BaseDamage=2, Level = 5, Gold = 0,LocationId =1, InventorySize = 10, Inventory = null, SkinColor = SkinColor.White, Username="andre",Password = "teste"});

            modelBuilder.Entity<Item>()
                .HasData(
                new Item { ItemId = 1, Name = "Potion", Description = "Heals your HP", Value = 10 },
                new Item { ItemId = 2, Name = "Sword", Description = "A Great Sword", Value = 25 },
                new Item { ItemId = 3, Name = "Shield", Description = "Keep Your Guard Up", Value = 10 },
                new Item { ItemId = 4, Name = "Boots", Description = "Simple Boots", Value = 5 });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RPGameDb;Trusted_Connection=True;");
            }
        }
    }
}
