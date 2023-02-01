using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaJogos.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaJogos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JogoController : ControllerBase
    {
        public IEnumerable<Jogo> _jogo = new Jogo[]{
             
                new Jogo(){
                    JogoId = 1,
                    Nome = "ARK: SURVIVAL EVOLVED",
                    Descricao = @"Jogo que tem que domar dinossauros, depois usar eles e suas habilidades para poder sobreviver",
                    Valor = 55.99
                },
                 new Jogo(){
                    JogoId = 2,
                    Nome = "Rockeat League",
                    Descricao = @"Jogo de futebol com carros",
                    Valor = 36.99
                }
               
            };


        public JogoController()
        {

        }

        [HttpGet]
        public IEnumerable<Jogo> Get()
        {
            return _jogo;
        }

        [HttpGet("{id}")]
        public IEnumerable<Jogo> GetById(int id)
        {
            return _jogo.Where(jogo => jogo.JogoId == (id));
        }
    }
}