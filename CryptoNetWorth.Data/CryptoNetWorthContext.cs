using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CryptoNetWorth.Domain;

namespace CryptoNetWorth.Data
{
    public partial class CryptoNetWorthContext : DbContext
    {
        public virtual DbSet<DigitalAsset> DigitalAsset { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // the connection string should be stored in a settings file. here I'm masking the host so it's OK for demo purposes
            optionsBuilder.UseMySql(@"Server=mysql;User Id=cryptonetworthapp;Password=cryptonEtworth@@123;Database=cryptonetworth");
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