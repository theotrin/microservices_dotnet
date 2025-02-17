using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestauranteService.Dtos;

namespace RestauranteService.ItemServiceHttpClient
{
    public interface IItemServiceHttpClient
    {
        public void EnviaRestauranteParaItemService(RestauranteReadDto readDto);
    }
}