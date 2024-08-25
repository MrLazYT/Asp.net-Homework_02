using homework_2.Models;
using homework_2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace homework_2.Pages
{
    public class Task_04Model : PageModel
    {
        public List<Restaurant> Items { get; set; }

        public void OnGet()
        {
            Items = Restaurants.GetAll();
        }
    }
}
