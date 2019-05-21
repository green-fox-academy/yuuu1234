using System;
using System.Threading;
using System.Threading.Tasks;
using FoxCoin;
using FoxCoin.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class ConcurrencyTests
    {
        private readonly ITestOutputHelper output;

        public ConcurrencyTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        private (IAccountService, IFoxCoinService) InitializeServices(int maxRetryCount = 1)
        {
            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FoxCoin;Trusted_Connection=True;");
            ApplicationContext applicationContext = new MockContext(builder.Options);

            var accountService = new AccountService(applicationContext);
            var coinService = new FoxCoinService(applicationContext, maxRetryCount);

            return (accountService, coinService);
        }

        [Fact]
        public async Task TestConcurrencyIssue()
        {
            var (accountService1, coinService1) = InitializeServices();
            var (accountService2, coinService2) = InitializeServices();

            var from = accountService1.FindById(1);
            var to = accountService2.FindById(2);

            coinService1.GrantCoins(from, 400);

            var task1 = Task.Run(() => coinService1.Transfer(from, to, 100));
            var task2 = Task.Run(() => coinService2.Transfer(from, to, 100));

            var results = await Task.WhenAll(task1, task2);
            
            Assert.False(results[0].IsSucceeded && results[1].IsSucceeded);

            if (!results[0].IsSucceeded)
            {
                Assert.Equal(FoxCoinTransferStatus.ConcurrencyIssue, results[0].Status);
            }

            if (!results[1].IsSucceeded)
            {
                Assert.Equal(FoxCoinTransferStatus.ConcurrencyIssue, results[1].Status);
            }
        }

        [Fact]
        public async Task TestConcurrencyIssueWithRetry()
        {
            var (accountService1, coinService1) = InitializeServices(maxRetryCount: 3);
            var (accountService2, coinService2) = InitializeServices(maxRetryCount: 3);

            var from = accountService1.FindById(1);
            var to = accountService2.FindById(2);

            coinService1.GrantCoins(from, 400);

            var task1 = Task.Run(() => coinService1.Transfer(from, to, 100));
            var task2 = Task.Run(() => coinService2.Transfer(from, to, 100));

            var results = await Task.WhenAll(task1, task2);
            
            output.WriteLine(results[0].Reason);
            output.WriteLine(results[1].Reason);
            Assert.True(results[0].IsSucceeded && results[1].IsSucceeded);
        }
    }

    class MockContext : ApplicationContext
    {
        public MockContext(DbContextOptions options) : base(options)
        {
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            Thread.Sleep(500);
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
    }
}
