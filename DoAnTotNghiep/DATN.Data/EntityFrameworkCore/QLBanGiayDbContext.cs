using DATN.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.Data.EntityFrameworkCore
{
    public class QLBanGiayDbContext : DbContext
    {
        public QLBanGiayDbContext() { }
        public QLBanGiayDbContext(DbContextOptions<QLBanGiayDbContext> options) : base(options) { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillImport> BillImports { get; set; }
        public DbSet<BillImportInfo> BillImportInfoes { get; set; }
        public DbSet<BillInfo> BillInfoes { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_dbo.Accounts");
                entity.HasIndex(e => e.UserId, "IX_UserId");
                entity.HasOne(d => d.User).WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Accounts_dbo.Users_UserId");
            });
            modelBuilder.Entity<Asset>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_dbo.Assets");
                entity.HasIndex(e => e.ProducerId, "IX_ProducerId");
                entity.HasIndex(e => e.ProductId, "IX_ProductId");
                entity.HasOne(d => d.Producer).WithMany(p => p.Assets)
                    .HasForeignKey(d => d.ProducerId)
                    .HasConstraintName("FK_dbo.Assets_dbo.Producers_ProducerId");
                entity.HasOne(d => d.Product).WithMany(p => p.Assets)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.Assets_dbo.Products_ProductId");
            });
            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_dbo.Bills");
                entity.HasIndex(e => e.AccountId, "IX_AccountId");
                entity.Property(e => e.CreationTime).HasColumnType("datetime");
                entity.Property(e => e.Vat).HasColumnName("VAT");
                entity.HasOne(d => d.Account).WithMany(p => p.Bills)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_dbo.Bills_dbo.Accounts_AccountId");
            });
            modelBuilder.Entity<BillImport>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_dbo.BillImports");
                entity.HasIndex(e => e.UserId, "IX_UserId");
                entity.Property(e => e.CreationTime).HasColumnType("datetime");
                entity.HasOne(d => d.User).WithMany(p => p.BillImports)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.BillImports_dbo.Users_UserId");
            });
            modelBuilder.Entity<BillImportInfo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_dbo.BillImportInfoes");
                entity.HasIndex(e => e.BillImportId, "IX_BillImportId");
                entity.HasIndex(e => e.ProductId, "IX_ProductId");
                entity.HasOne(d => d.BillImport).WithMany(p => p.BillImportInfos)
                    .HasForeignKey(d => d.BillImportId)
                    .HasConstraintName("FK_dbo.BillImportInfoes_dbo.BillImports_BillImportId");
                entity.HasOne(d => d.Product).WithMany(p => p.BillImportInfos)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.BillImportInfoes_dbo.Products_ProductId");
            });
            modelBuilder.Entity<BillInfo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_dbo.BillInfoes");
                entity.HasIndex(e => e.BillId, "IX_BillId");
                entity.HasIndex(e => e.ProductId, "IX_ProductId");
                entity.HasOne(d => d.Bill).WithMany(p => p.BillInfos)
                    .HasForeignKey(d => d.BillId)
                    .HasConstraintName("FK_dbo.BillInfoes_dbo.Bills_BillId");
                entity.HasOne(d => d.Product).WithMany(p => p.BillInfos)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.BillInfoes_dbo.Products_ProductId");
            });
            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_dbo.Carts");
                entity.HasIndex(e => e.AccountId, "IX_AccountId");
                entity.HasIndex(e => e.ProductId, "IX_ProductId");
                entity.HasOne(d => d.Account).WithMany(p => p.Carts)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_dbo.Carts_dbo.Accounts_AccountId");
                entity.HasOne(d => d.Product).WithMany(p => p.Carts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.Carts_dbo.Products_ProductId");
            });
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_dbo.Categories");
            });
            modelBuilder.Entity<Producer>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_dbo.Producers");
            });
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_dbo.Products");
                entity.HasIndex(e => e.CategoryId, "IX_CategoryId");
                entity.HasIndex(e => e.ProducerId, "IX_ProducerId");
                entity.Property(e => e.CreationTime).HasColumnType("datetime");
                entity.HasOne(d => d.Category).WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.Products_dbo.Categories_CategoryProductId");
                entity.HasOne(d => d.Producer).WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProducerId)
                    .HasConstraintName("FK_dbo.Products_dbo.Producers_ProducerId");
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_dbo.Users");
            });
        }
    }
}
