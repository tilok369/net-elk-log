using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net.ELK.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    _logger.LogInformation("Iteration count {i}", i);
                else
                    _logger.LogError(new Exception("Odd variable found!"), "An error occurred");
            }
        }
    }
}
