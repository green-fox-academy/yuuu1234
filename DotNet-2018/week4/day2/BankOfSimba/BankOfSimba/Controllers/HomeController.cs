using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models.BankOfSimba;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        private static List<BankAccount> accountList = new List<BankAccount>()
        {
            new BankAccount("Simba", 1000, "lion", "Good",true),
            new BankAccount("Scar",800,"lion","Bad",false),
            new BankAccount("Nala",500,"lion","Good",false),
            new BankAccount("Zazu",100,"bird","Good",false)
        };

        [HttpGet("/show")]
        public IActionResult Show()
        {
            BankAccount newAccount = new BankAccount("Simba", 2000, "lion", "Good", false);
            return View(newAccount);
        }

        [HttpGet("/string")]
        public IActionResult String()
        {
            return View();
        }

        [HttpGet("multiple")]
        public IActionResult MultipleAccounts()
        {
            return View(accountList);
        }

        [HttpGet("form")]
        public IActionResult Form()
        {
            return View(accountList);
        }

        [HttpPost("form")]
        public IActionResult RaiseAccount(string animal)
        {
            foreach (var bankAccount in accountList)
            {
                if (bankAccount.Name == animal && bankAccount.King == false)
                {
                    string newBalance = (float.Parse(bankAccount.Balance) + 10).ToString("F");
                    bankAccount.Balance = newBalance;
                }
                else if (bankAccount.Name == animal && bankAccount.King == true)
                {
                    string newBalance = (float.Parse(bankAccount.Balance) + 100).ToString("F");
                    bankAccount.Balance = newBalance;
                }
            }
            return RedirectToAction(nameof(MultipleAccounts));
        }

        [HttpGet("add")]
        public IActionResult AddForm()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult AddAccount(BankAccount account)
        {
            string keep2Decimal = float.Parse(account.Balance).ToString("F");
            account.Balance = keep2Decimal;
            accountList.Add(account);
            return RedirectToAction(nameof(MultipleAccounts));
        }

    }
}