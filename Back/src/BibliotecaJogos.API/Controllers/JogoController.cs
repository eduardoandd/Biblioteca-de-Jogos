using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaJogos.API.Data;
using BibliotecaJogos.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaJogos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JogoController : ControllerBase
    {
        private readonly DataContext _context;

        public JogoController(DataContext context)
        {
            _context = context;
            
        }

        [HttpGet]
        public IEnumerable<Jogo> Get()
        {
            return _context.Jogos;
        }

        [HttpGet("{id}")]
        public Jogo GetById(int id)
        {
            return _context.Jogos.FirstOrDefault(jogo => jogo.JogoId == (id));
        }
    }
}