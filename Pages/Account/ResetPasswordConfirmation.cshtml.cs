using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Smp.NobleUI.Pages.Account
{
    [AllowAnonymous]
    public class ResetPasswordConfirmationModel : AccountPageModel
    {
        [BindProperty(SupportsGet = true)]
        public string ReturnUrl { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ReturnUrlHash { get; set; }

        public virtual Task<IActionResult> OnGetAsync()
        {
            ReturnUrl = GetRedirectUrl(ReturnUrl, ReturnUrlHash);

            return Task.FromResult<IActionResult>(Page());
        }
    }
}
