using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FILMES_MVC.Controllers
{
    [Route("[controller]")]
    public class FilmeController : Controller
    {
        private readonly FilmeRepository _repository;

        public FilmeController(FilmeRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            List<Filme> filmes = _repository.ObterFilmes();
            return View(filmes);
        }

    }
}