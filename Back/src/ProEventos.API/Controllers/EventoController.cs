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
        public EventoController(ILogger<EventoController> logger)
        {
            
        }

        [HttpGet]
        public List<Evento> Get()
        {           
           return new List<Evento>(){
               
                    new Evento(){
                        EventoId = 1,
                        Tema = "encontro Turma",
                        Local = "Araraquara",
                        QtdPessoas = 20,
                        Lote = "Primeiro",
                        DataEvento = DateTime.Now.AddDays(2).ToString(),
               },
                    new Evento(){
                        EventoId = 2,
                        Tema = "encontro Professores",
                        Local = "Rio de Janeiro",
                        QtdPessoas = 2,
                        Lote = "Segundo",
                        DataEvento = DateTime.Now.AddDays(9).ToString(),
                    }
               };
        }

        [HttpPost]
        public string Post(){
            return "salvando... com post";
        }

        [HttpDelete("{id}")]
        public string Delete(int id){
            return $"Delete com {id}";
        }

        [HttpPut("{id}")]
        public string Put(int id){
            return $"Atualizando com {id}";
        }
    }
}
