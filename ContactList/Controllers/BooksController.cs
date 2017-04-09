using ContactList.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactList.Controllers
{
    
    public class BooksController : Controller
    {
        private ContactsDbContext _context ;

        public BooksController(ContactsDbContext ctx)
        {
            _context = ctx;
        }

    }
}