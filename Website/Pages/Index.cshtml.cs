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
        /// <summary>
        /// This is  read only ILogger
        /// </summary>
        private readonly ILogger<IndexModel> _logger;
        /// <summary>
        /// This property mentions the MenuItems
        /// </summary>
        public IEnumerable<IOrderItem> MenuItems { get; set; }
        /// <summary>
        /// This is the indexmodel
        /// </summary>
        /// <param name="logger"></param>
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// This is the onGet method that displays all of the backend code
        /// </summary>
        public void OnGet()
        {
            MenuItems = Menu.Search(SearchTerms);
            MenuItems = Menu.FilterByCategory(MenuItems, Category);
            MenuItems = Menu.FilterByCalories(MenuItems, CaloriesMin, CaloriesMax);
            MenuItems = Menu.FilterByPrice(MenuItems, PriceMin, PriceMax);
        }
        /// <summary>
        /// This property searchTerms
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }
        /// <summary>
        /// The property Category
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] Category { get; set; }
        /// <summary>
        /// The property CaloriesMin
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int CaloriesMin { get; set; }
        /// <summary>
        /// The property CaloriesMax
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int CaloriesMax { get; set; } = 1000;
        /// <summary>
        /// The property PriceMin
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double PriceMin { get; set; }
        /// <summary>
        /// The property PriceMax
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double PriceMax { get; set; } = 10;
    }
}
