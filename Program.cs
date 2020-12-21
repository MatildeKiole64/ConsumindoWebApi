using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ConsumindoWebApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/users";
            var http = new HttpClient();
            var response = await http.GetStringAsync(url);
            var utilizadores = JsonConvert.DeserializeObject<List<Utilizador>>(response);
            foreach (var utilizador in utilizadores)
            {
                Console.WriteLine("Nome utilizador: {0}, Email: {1}", utilizador.Username, utilizador.Email);
            }
        }
    }
}
