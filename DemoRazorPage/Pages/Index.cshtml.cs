using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoRazorPage.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string SearchName { get; set; }

        [BindProperty]
        public string Name { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
    }
}