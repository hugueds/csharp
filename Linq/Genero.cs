using System.Linq;
using System.Collections.Generic;

namespace Linq
{
public class Genero
    {
        public int Id {get ; set;}
        public string Name {get;set;}

        public Genero(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public static void ListAll(IList<Genero> collection)
        {
            foreach (var c in collection)
            {
                System.Console.WriteLine(c.Name);
            }
        }

        public static void ListOne(IList<Genero> collection, string type)
        {
            foreach (var c in collection)
            {
                if (c.Name.Contains(type))
                {
                    System.Console.WriteLine(c.Name);                    
                }
            }
        }       
    }
}