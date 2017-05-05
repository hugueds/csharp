using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using abcdef.Models;
using System.IO;
using System;

namespace abcdef
{
    public class WebApi
    {
        private const string url = @"https://jsonplaceholder.typicode.com/";

        public async Task<List<Post>> GetPosts()
        {
            var httpClient = new HttpClient();

            Console.Write("Making the request");

            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            
            var response = await httpClient.GetAsync(url + "posts").ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                {
                    return JsonConvert.DeserializeObject<List<Post>>(
                        await new StreamReader(responseStream).ReadToEndAsync().ConfigureAwait(false));
                }
            }
            else
            {
                Console.WriteLine("Erro na requisição");
                return null;
            }


        }
        
    }
}