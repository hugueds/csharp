//<sumary>
//Codigo para introducao do Linq
//LINQ => Language Integrated Query
//</sumary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linq
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var generos = new List<Genero>();
            generos.Add(new Genero(1,"Rock"));
            generos.Add(new Genero(2,"Rock and Roll"));
            generos.Add(new Genero(3,"Samba"));
            generos.Add(new Genero(4,"Eletro"));

            Genero.ListOne(generos, "Rock");

            var query = from g in generos
                        select g;
            foreach (var gen in query)
            {
                System.Console.WriteLine("ID:{0}\tGenero:{1}", gen.Id, gen.Name);
            }


            Console.ReadKey();
        }
    }

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
