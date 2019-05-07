using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FoxCoin.Models;
using FoxCoin.Services;

namespace FoxCoin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAccountService accountService;
        private readonly ICurrentAccountService currentAccountService;
        private readonly IFoxCoinService foxCoinService;

        public HomeController(IAccountService accountService, ICurrentAccountService currentAccountService, IFoxCoinService foxCoinService)
        {
            this.accountService = accountService;
            this.currentAccountService = currentAccountService;
            this.foxCoinService = foxCoinService;
        }

        public IActionResult Index()
        {
            var userAccounts = accountService.GetAccounts();

            return View(userAccounts);
        }

        [HttpGet("generate")]
        public IActionResult GeneratePage()
        {
            return View();
        }

        [HttpPost("generate")]
        public IActionResult Generate()
        {
            int amount = foxCoinService.GenerateRandomFoxCoin(currentAccountService.CurrentAccount);
            TempData["generatedValue"] = amount;
            return RedirectToAction(nameof(GeneratePage));
        }

        [HttpGet("statistics")]
        public IActionResult Statistics()
        {
            TransactionStatistics statistics = foxCoinService.GetStatistics();
            return View(statistics);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
