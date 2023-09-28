using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReolMarkedet.Domain.Entities;

namespace ReolMarkedet.DataAccess.Context
{
    public class ReolMarkedetDbContext : DbContext
    {
        public ReolMarkedetDbContext(DbContextOptions<ReolMarkedetDbContext> options) : base(options) { }

        public DbSet<Barcode> Barcodes { get; set; }
        public DbSet<Payout> Payouts { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<ShelfTenant> Shelftenants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShelfTenant>().HasData(
                new ShelfTenant { tenantId = 1, firstName = "Chuck",    lastName = "Norris",    phone = "12345678", email = "chuck@norris.dk"},
                new ShelfTenant { tenantId = 2, firstName = "Chris",    lastName = "Chrissie",  phone = "23456789", email = "ch@ris.dk" },
                new ShelfTenant { tenantId = 3, firstName = "Cri",      lastName = "sti",       phone = "34567890", email = "hmm@mmm.dk" }
                );

            modelBuilder.Entity<Barcode>().HasData(
                new Barcode { barcodeInNumbers = 1, discountInPercentage = 0,   ShelfTenanttenantId = 1 },
                new Barcode { barcodeInNumbers = 2, discountInPercentage = 15,  ShelfTenanttenantId = 1 },
                new Barcode { barcodeInNumbers = 3, discountInPercentage = 50,  ShelfTenanttenantId = 1 }
                );

            modelBuilder.Entity<Payout>().HasData(
                new Payout { payoutId = 1, fine = 0,    commission = 0,     totalPayout = 0,    totalSale = 0,      commissionDeduction = 0,    ShelfTenanttenantId = 1 },
                new Payout { payoutId = 2, fine = 350,  commission = 0,     totalPayout = 0,    totalSale = 0,      commissionDeduction = 0,    ShelfTenanttenantId = 1 },
                new Payout { payoutId = 3, fine = 0,    commission = 150,   totalPayout = 850,  totalSale = 1000,   commissionDeduction = 150,  ShelfTenanttenantId = 1 }
                );
            
            modelBuilder.Entity<Sale>().HasData(
                new Sale { saleId = 1, price = 100, discountInPercentage = 0,   priceOfSale = 100,  barcodeInNumbers = 1 },
                new Sale { saleId = 2, price = 50,  discountInPercentage = 50,  priceOfSale = 25,   barcodeInNumbers = 2 },
                new Sale { saleId = 3, price = 150, discountInPercentage = 0,   priceOfSale = 150,  barcodeInNumbers = 3 }
                );

        }
    }
}
