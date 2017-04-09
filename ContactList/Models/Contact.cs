using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ContactList.Models
{
    public class Contact
    {
        public int ContactId {get;set;}
        [Required]
        [DisplayAttribute(Name = "First Name", Prompt = "Insert the First Name")]
        public string FirstName {get;set;}
        [Required]
        [DisplayAttribute(Name = "Last Name", Prompt = "Insert the Last Name")]
        public string LastName {get;set;}

        [DisplayAttribute(Name = "Telephone", Prompt = "Insert the Telephone ")]
        public string Telephone {get;set;}

        [EmailAddressAttribute]
        [DisplayAttribute(Name = "Email", Prompt = "Insert the Email")]
        public string EmailAddress {get;set;}
        public IList<Book> Books {get;set;}
    }
}