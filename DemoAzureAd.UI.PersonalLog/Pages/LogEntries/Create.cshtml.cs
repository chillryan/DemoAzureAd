using System.Threading.Tasks;
using DemoAzureAd.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoAzureAd.UI.PersonalLog.Pages.Logs
{
    public class CreateModel : PageModel
    {
        private readonly PersonalLogContext _personalLog;

        public CreateModel(PersonalLogContext personalLog)
        {
            _personalLog = personalLog;
        }

        [BindProperty]
        public LogEntry Entry { get; set; }

        public IActionResult OnGet()
        {
            Entry = new LogEntry
            {
                AccessLevel = AccessLevel.Supplemental,
                Author = HttpContext.User.Identity.Name
            };

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _personalLog.LogEntries.Add(Entry);
            await _personalLog.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
