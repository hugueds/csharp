using System.Linq;
using System.Threading.Tasks;
using ContactList.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactList.Controllers
{
    public class ContactsController : Controller
    {
        private ContactsDbContext _dbContext;       

        public ContactsController(ContactsDbContext dbContext)
        {
            _dbContext = dbContext;
            
        }


        [HttpGet]
        public IActionResult Index()
        {
            _dbContext.Books.Add(new Book(){
                Title  = "Era uma vez"
            });
            
            return View(_dbContext.Contacts);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Contact contact)
        {
            _dbContext.Contacts.Add(contact);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var contact = _dbContext.Contacts.FirstOrDefault(c => c.ContactId == id);
            if (contact == null)
                return NotFound();
            return View(contact);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Contact contact)
        {
            _dbContext.Contacts.Update(contact);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        


    }
    
}