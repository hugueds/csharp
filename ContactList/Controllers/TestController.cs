using System;
using ContactList.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ContactList.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        
        private ContactsDbContext _context;
        public TestController(ContactsDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Contact> GetAll()
        {
            Debug.WriteLine(_context.ToString());
            return _context.Contacts.ToList();
        }
        
    }
   
}