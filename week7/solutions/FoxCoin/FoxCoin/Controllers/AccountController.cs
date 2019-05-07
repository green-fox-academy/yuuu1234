using System;
using FoxCoin.Services;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace FoxCoin.Controllers
{
    public class AccountController : Controller
    {
        private readonly ICurrentAccountService currentAccountService;
        private readonly IAccountService accountService;

        public AccountController(ICurrentAccountService currentAccountService, IAccountService accountService)
        {
            this.currentAccountService = currentAccountService;
            this.accountService = accountService;
        }

        [HttpPost("switch-user")]
        public IActionResult Switch(long? accountId, string returnUrl)
        {
            var (url, isSecure) = GetSecureUri(returnUrl);

            if (!isSecure)
            {
                return RedirectToRoute("default");
            }

            if (accountId == null)
            {
                return Redirect(url);
            }

            currentAccountService.SwitchTo(accountId.Value);

            return Redirect(url);
        }

        private (string url, bool isSecure) GetSecureUri(string returnUrl)
        {
            if (!Uri.IsWellFormedUriString(returnUrl, UriKind.Relative))
            {
                return (null, false);
            }

            var baseUri = new Uri(Request.GetDisplayUrl(), UriKind.Absolute);
            var url = new Uri(baseUri, returnUrl);

            return (url.ToString(), true);
        }

        [HttpPost("delete-account")]
        public IActionResult Delete(long? accountId)
        {
            if (accountId == null)
            {
                return RedirectToAction("Index", "Home");
            }

            accountService.Delete(accountId.Value);

            return RedirectToAction("Index", "Home");
        }
    }
}