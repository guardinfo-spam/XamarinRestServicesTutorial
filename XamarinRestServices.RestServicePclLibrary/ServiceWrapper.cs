using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using XamarinRestServices.Models;

namespace XamarinRestServices.RestServicePclLibrary
{
    public sealed class ServiceWrapper : IServiceWrapper
    {
        public async Task<string> GetData(string id)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("http://xamarin-rest-service.azurewebsites.net/demo/getdata?id=" + id);
                return await result.Content.ReadAsStringAsync();
            }
        }

        public async Task<string> RegisterUserJsonRequest(UserModel model)
        {
            using (var client = new HttpClient())
            {               
                var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");               
                
                var result = await client.PostAsync("http://xamarin-rest-service.azurewebsites.net/demo/registeruser", content);
                return await result.Content.ReadAsStringAsync();
            }
        }

        public async Task<string> RegisterUserFormRequest(UserModel model)
        {
            using (var client = new HttpClient())
            {                
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("Username", model.Username),
                    new KeyValuePair<string, string>("Password", model.Password)
                });

                var result = await client.PostAsync("http://xamarin-rest-service.azurewebsites.net/demo/registeruser", content);
                return await result.Content.ReadAsStringAsync();
            }
        }
    }
}
