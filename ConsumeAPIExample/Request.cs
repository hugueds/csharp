using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;
using System.Runtime.Serialization.Json;

namespace ConsumeAPIExample
{   
    public class Request
    {
        public static async Task GetData()
        {           
            try
            {
                using (HttpClient client = new HttpClient())
                {                     
                    var serializer = new DataContractJsonSerializer(typeof(List<string>));
                    var response = client.GetStringAsync("http://localhost:5000/api/values");                   
                    var msg = await response;
                    Console.Write(msg);
                }
            }
            catch(WebException e)
            {
                Console.WriteLine(e.Message);
            }            
            
            
        }              
       
        
    }
}