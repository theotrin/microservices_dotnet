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
        public ItemServiceHttpClient(HttpClient client)
        {
            _client = client;
        }
        public void EnviaRestauranteParaItemService(RestauranteReadDto readDto)
        {
           var conteudoHttp = new StringContent
           (
                JsonSerializer.Serialize(readDto),
                Encoding.UTF8,
                "application/json"
           );
        }
    }
}