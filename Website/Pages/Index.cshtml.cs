using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Interface;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<IOrderItem> Menu { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        [BindProperty(SupportsGet = true)]
        public int CaloriesMin { get; set; }
        [BindProperty(SupportsGet = true)]
        public int CaloriesMax { get; set; } = 1000;
        [BindProperty(SupportsGet = true)]
        public double PriceMin { get; set; }
        [BindProperty(SupportsGet = true)]
        public double PriceMax { get; set; } = 10;
    }
}
