using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FILMES_MVC.Repositories
{
    public class FilmeRepository
    {
        private readonly FilmeDBContext _context;


        public FilmeRepository(FilmeDBContext context)
        {
            _context = context;
        }

        public List<Filme> ObterFilmes()
        {
            return _context.Filme.ToList();
        }
    }
}