using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_AspNetCore.Models.Dados
{
    public class FilmesContext : DbContext
    {

        public FilmesContext(DbContextOptions<FilmesContext> options)
         : base(options)
        {
        }

        public DbSet<Filme> Filme { get; set; }
    }
}
