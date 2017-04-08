using System.ComponentModel.DataAnnotations;

namespace ContactList.Models
{
    public class Contact
    {
        public int ContactId {get;set;}
        [Required]
        public string FirstName {get;set;}
        [Required]
        public string LastName {get;set;}
        public string Telephone {get;set;}
        [EmailAddressAttribute]
        public string EmailAddress {get;set;}
    }
}