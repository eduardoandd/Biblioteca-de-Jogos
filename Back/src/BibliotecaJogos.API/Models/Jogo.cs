using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaJogos.API.Models
{
    public class Jogo
    {
        public int JogoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string ImagemURL { get; set; }
    }
}