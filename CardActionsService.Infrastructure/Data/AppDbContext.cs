using CardActionsService.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;


namespace CardActionsService.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<AllowedAction> Actions { get; set; }
        public DbSet<CardAction> CardActions { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CardAction>()
            .HasOne(ca => ca.Action)
            .WithMany()
            .HasForeignKey(ca => ca.ActionId);

            modelBuilder.Entity<CardAction>()
                .HasIndex(ca => new { ca.CardType, ca.CardStatus, ca.ActionId })
                .IsUnique();
        }
    }
}
