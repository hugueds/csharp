using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}