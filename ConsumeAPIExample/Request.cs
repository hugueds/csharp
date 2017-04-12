using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;


namespace ConsumeAPIExample
{
    
    public class Request
    {
        public static JsonResult GetData()
        {
            JsonResult emptyResponse = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {                     
                    HttpResponseMessage response = client.GetAsync("http://localhost:5000/api/values").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        
                    }
                }
            }
            catch(WebException e)
            {
                Console.WriteLine(e.Message);
            }            
            return emptyResponse;
            
        }        
        
       
        
    }
}