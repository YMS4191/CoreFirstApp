using Microsoft.AspNetCore.Mvc;

namespace mvcapp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Home Index";
        }

        public string About()
        {
            return "Home About";
        }

        public string Contact()
        {
            return "Home Contact";
        }
    }
}
// shift + alt + f