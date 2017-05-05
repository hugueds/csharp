
namespace WebApiExample.Models
{    public class Person
    {

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get;  set; }
        public int Age { get;  set; }
        public string Email { get;  set; }
    }
}