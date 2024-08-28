using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] 
        {
            new Evento()
            {
                EventoId = 1,
                Tema = "Angular 11 e .Net 5",
                Local = "BH",
                Lote = "Primeiro Lote",
                Qtdpessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "Foto.png"
            },
            new Evento()
            {
                EventoId = 2,
                Tema = "Angular e suas novidades",
                Local = "SP",
                Lote = "Segundo Lote",
                Qtdpessoas = 350,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "Foto.png"
            }
        };

        public EventoController(ILogger<EventoController> logger)
        {
        }
    
        [HttpGet]
        public IEnumerable <Evento> Get()
        {
           return _evento;
           
        }

        [HttpGet("{id}")]
        public IEnumerable <Evento> GetById(int id)
        {
           return _evento.Where(evento => evento.EventoId == id);
           
        }

        [HttpPost]
        public string Post()
        {
           return "Exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Exemplo de de put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return $"Exemplo de de delete com id = {id}";
        }
    }
}
