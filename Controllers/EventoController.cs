using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvents.API.Models;

namespace ProEvents.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable <Evento> Get()
        {
         return new Evento[] {
            new Evento  {
             EventoId = 1,
             Tema = "Angular 11",
             Local = "Parintins",
             DataEvento = DateTime.Now.AddDays(2).ToString(),
             Lote = "1° Lote",
             Quantidade = 250,
             ImagemURL = "teste"
            }
         };
      
        }

        [HttpPost]
        public string Post([FromBody] string name)
        {
         return $"Nome: {name}";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
         return $"Exemplo de Put com id = {id}";
        }
    }
}
