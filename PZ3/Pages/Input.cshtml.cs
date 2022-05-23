using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PZ3.Pages
{
    public class InputModel : PageModel
    {
        public void OnPost()
        {
            var key = Request.Form["key"];
            var value = Request.Form["value"];
            HttpContext.Session.SetString(key, value);
        }
    }
}