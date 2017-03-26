using Microsoft.AspNetCore.Mvc;

namespace ContactList.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    
}