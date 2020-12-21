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
            var http = new HttpClient();
            var response = await http.GetStringAsync("https://jsonplaceholder.typicode.com/users");
            var utilizadores = JsonConvert.DeserializeObject<List<Utilizador>>(response);
            foreach (var utilizador in utilizadores)
            {
                Console.WriteLine("====================Dados Pessoais========================");
                Console.WriteLine("Nome utilizador: {0}", utilizador.Username);
                Console.WriteLine("Email: {0}", utilizador.Email);
                Console.WriteLine("Telefone: {0}", utilizador.Phone);
                Console.WriteLine("WebSite: {0}", utilizador.WebSite);

                Console.WriteLine("-----Morada------");
                Console.WriteLine("Rua: {0}", utilizador.Address.Street);
                Console.WriteLine("Suite: {0}", utilizador.Address.Suite);
                Console.WriteLine("Cidade: {0}", utilizador.Address.City);
            }
        }
    }
}
