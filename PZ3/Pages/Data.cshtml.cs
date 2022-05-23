using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PZ3.Pages
{
    public class DataModel : PageModel
    {
        public Dictionary<string, string> sessionStates = new();

        public void OnGet()
        {
            foreach (var key in HttpContext.Session.Keys)
            {
                sessionStates.Add(key, HttpContext.Session.GetString(key) ?? "null");
            }
        }
    }
}