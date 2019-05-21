using System;
using FoxCoin.Models;
using Microsoft.EntityFrameworkCore;

namespace FoxCoin
{
    public class ApplicationContext : DbContext
    {
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<PersonalAccount> PersonalAccounts { get; set; }
        public DbSet<CorporateAccount> CorporateAccounts { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbQuery<TransactionStatistics> TransactionStatistics { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var account1 = new UserAccount { Id = 1, Balance = 100, Username = "john" };
            var account2 = new UserAccount { Id = 2, Balance = 100, Username = "jane" };
            var account3 = new UserAccount { Id = 3, Balance = 100, Username = "sarah" };
            var account4 = new UserAccount { Id = 4, Balance = 100, Username = "david" };

            modelBuilder.Entity<UserAccount>().HasData(
                account1,
                account2,
                account3,
                account4
            );

            modelBuilder.Entity<Transaction>().HasData(
                new Transaction { TransactionId = 1, SenderId = account1.Id, ReceiverId = account2.Id, Timestamp = DateTime.UtcNow }
            );

            modelBuilder.Query<TransactionStatistics>().ToView("TransactionStatistics");

            modelBuilder.Entity<PersonalAccount>()
                .HasMany(a => a.Friends)
                .WithOne(a => a.Friend)
                .IsRequired(false);
        }
    }
}