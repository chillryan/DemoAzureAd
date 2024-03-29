using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAzureAd.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DemoAzureAd.UI.PersonalLog.Pages.Logs
{
    [Authorize] 
    public class IndexModel : PageModel
    {
        private readonly PersonalLogContext _personalLog;

        public IndexModel(PersonalLogContext personalLog)
        {
            _personalLog = personalLog;
        }

        public IList<LogEntry> LogEntries { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var inquiry = from l in _personalLog.LogEntries
                          orderby l.Date
                          select l;

            LogEntries = await inquiry.ToListAsync();

            return Page();
        }
    }
}
