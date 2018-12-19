using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Threading.Tasks;
using AppTestingJSON.Model;


namespace AppTestingJSON.Service
{
    class RestService : IRestService
    {
        HttpClient client;
        public Book item { get; set; }

        public RestService() 
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            item = new Book();

        }

        public async Task<Book> RefreshDataAsync()
        {
            //URI
            var uri = new Uri("http://hibooks.fr/api/book/5a8f12e16a16fa06d1f5b0c7");
        
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    item = JsonConvert.DeserializeObject<Book>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }
            
            return item;
        }
    }
}
