using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Threading.Tasks;
using AppLoginHibooks.Model;
using AppLoginHibooks.Data.Util;


namespace AppLoginHibooks.Data
{
    class LoginConsumer : ILoginConsumer
    {
        HttpClient client;
        public User item { get; set; }

        public LoginConsumer()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            item = new User();

        }

        public async Task<int> loginAsync(Login login)
        {
            //URI
            var uri = new Uri("http://hibooks.fr/api/login");
            var payload = login;
            int res = 0;

            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("email", login.Email),
                new KeyValuePair<string, string>("password", login.Password)
            });

            try
            {
                var response = await client.PutAsync(uri, formContent);
                Debug.WriteLine("la");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    App.user = JsonConvert.DeserializeObject<User>(content);
                    Debug.WriteLine("ici réussi !");
                    res = 1;
                }
                else { res = 2; }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }

            return res;
        }

        public async Task<int> logoutAsync()
        {
            int res = 0;
            //URI
            var uri = new Uri("http://hibooks.fr/api/logout");

            try
            {
                var response = await client.GetAsync(uri);
                Debug.WriteLine("la");
                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine("ici réussi !");
                    res = 1;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }

            return res;
        }
    }
}
