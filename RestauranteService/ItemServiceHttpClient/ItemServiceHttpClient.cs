using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RestauranteService.Dtos;

namespace RestauranteService.ItemServiceHttpClient
{
    public class ItemServiceHttpClient : IItemServiceHttpClient
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;
        public ItemServiceHttpClient(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _configuration = configuration;
        }

        public async void EnviaRestauranteParaItemService(RestauranteReadDto readDto)
        {
           var conteudoHttp = new StringContent
           (
                JsonSerializer.Serialize(readDto),
                Encoding.UTF8,
                "application/json"
           );

           await _client.PostAsync(_configuration["ItemService"],conteudoHttp);
        }
    }
}