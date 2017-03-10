//<sumary>
//Codigo para introducao do Linq
//LINQ => Language Integrated Query
//</sumary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var generos = new List<Genero>();
            generos.Add(new Genero(1,"Glam Rock"));
            generos.Add(new Genero(2,"Rock and Roll"));
            generos.Add(new Genero(3,"Samba"));
            generos.Add(new Genero(4,"Eletro"));

            //Genero.ListOne(generos, "Rock"); //Imprime filtro manual

            var query = from g in generos
                        select g;
            foreach (var gen in query)
            {
                //System.Console.WriteLine("ID:{0}\tGenero:{1}", gen.Id, gen.Name);
            }

            var musicas = new List<Musica>()
            {
                new Musica{Id = 1, Name = "Cherry Pie", GeneroId = 1},
                new Musica{Id = 2, Name = "Blue Suede Shoes", GeneroId = 2},
                new Musica{Id = 3, Name = "A Grande Familia Theme", GeneroId = 3},
                new Musica{Id = 4, Name = "Faixa Amarela", GeneroId = 3}
            };

            var query2 = from m in musicas
                        join g in generos on m.GeneroId equals g.Id
                        select new { m,g };
            foreach (var mus in query2)
            {
                //System.Console.WriteLine("ID: {0}\tName: {1}\tGenero: {2}", mus.m.Id, mus.m.Name, mus.g.Name);
            }


            XElement root = XElement.Load(@"Data/Tunes.xml");
            var queryXML = from g in root.Element("Generos").Elements("Genero")
                            join m in root.Element("Musicas").Elements("Musica")
                            on g.Element("GeneroId").Value equals m.Element("GeneroId").Value
                            select new
                            {
                                mus = m.Element("Nome").Value,                  
                                gen = g.Element("Nome").Value
                            };

            foreach(var genero in queryXML)
            {
                Console.WriteLine("{0}\t\t{1}",genero.mus,genero.gen);                
            }

            

            Console.ReadKey();
        }
    }
    
}
