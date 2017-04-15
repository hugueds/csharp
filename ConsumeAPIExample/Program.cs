using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumeAPIExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(">> APP RUNNING...");

            var request = Request.GetData();      

            //JavaScriptSerializer serializer = new JavaScriptSerializer();

            System.Console.WriteLine("1" + request);

            Console.ReadKey();
            



            
        }
    }
}
