using System.Linq;
using Microsoft.EntityFrameworkCore;
using CryptoNetWorth.Domain;

namespace CryptoNetWorth.Data
{
    public partial class CryptoNetWorthContext : DbContext
    {
        public virtual DbSet<DigitalAsset> DigitalAsset { get; set; }

        public static string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString);
        }

        public void EnsureSeedData()
        {
            if (!DigitalAsset.Any())
            {
				var btc = new DigitalAsset()
				{
					Name = "Bitcoin",
					Symbol = "BTC",
					Units = .25
				};

				var eth = new DigitalAsset()
				{
					Name = "Ether",
					Symbol = "ETH",
					Units = 7
				};

				var ltc = new DigitalAsset()
				{
					Name = "Litecoin",
					Symbol = "LTC",
					Units = 5
				};

                DigitalAsset.Add(btc);
                DigitalAsset.Add(eth);
                DigitalAsset.Add(ltc);

                this.SaveChanges();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DigitalAsset>(entity =>
            {
                entity.ToTable("digital_asset");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasColumnName("symbol")
                    .HasColumnType("varchar(11)");

                entity.Property(e => e.Units).HasColumnName("units");
            });
        }
    }
}