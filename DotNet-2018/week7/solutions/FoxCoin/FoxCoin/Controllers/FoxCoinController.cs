using System.Linq;
using FoxCoin.Models;
using FoxCoin.Services;
using FoxCoin.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FoxCoin.Controllers
{
    public class FoxCoinController : Controller
    {
        private readonly ICurrentAccountService currentAccountService;
        private readonly IAccountService accountService;
        private readonly IFoxCoinService foxCoinService;

        public FoxCoinController(ICurrentAccountService currentAccountService, IAccountService accountService, IFoxCoinService foxCoinService)
        {
            this.currentAccountService = currentAccountService;
            this.accountService = accountService;
            this.foxCoinService = foxCoinService;
        }

        [HttpGet("transfer")]
        public IActionResult TransferPage()
        {
            var currentAccount = currentAccountService.CurrentAccount;

            if (currentAccount == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(new TransferViewModel
            {
                FromAccount = currentAccount,
                Accounts = accountService.GetAccounts().Where(a => a.Id != currentAccount.Id).ToList()
            });
        }

        [HttpPost("transfer")]
        public IActionResult Transfer(UserAccount fromAccount, UserAccount targetAccount, decimal amount)
        {
            var result = foxCoinService.Transfer(fromAccount, targetAccount, amount);

            if (result.IsSucceeded)
            {
                return RedirectToAction("Index", "Home");
            }

            TempData["failedReason"] = result.Reason;

            return RedirectToAction(nameof(TransferPage));
        }

        [HttpGet("transaction-history")]
        public IActionResult TransactionHistory(long? receiverId, long? senderId)
        {
            ViewBag.receiverId = receiverId;
            ViewBag.senderId = senderId;
            var result = foxCoinService.GetTransactionHistory(currentAccountService.CurrentAccount, receiverId, senderId);

            return View(result);
        }
    }
}