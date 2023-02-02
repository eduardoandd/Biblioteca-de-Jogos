using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaJogos.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaJogos.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Jogo> Jogos {get; set;}
    }
}