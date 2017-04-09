using ContactList.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactList.Controllers
{
    
    public class BooksController : Controller
    {
        private BooksDbContext _context ;

        public BooksController(BooksDbContext ctx)
        {
            _context = ctx;
        }

    }
}