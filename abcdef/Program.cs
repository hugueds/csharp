using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abcdef
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApi api = new WebApi();

            var posts = api.GetPosts();

            Console.WriteLine(posts);

        }
    }
}
