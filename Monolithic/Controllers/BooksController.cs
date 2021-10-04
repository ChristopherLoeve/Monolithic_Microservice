using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Monolithic.Data;
using Monolithic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monolithic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly Repository _repository;

        public BooksController(ILogger<BooksController> logger, Repository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Book> Get() => _repository.GetBooks();
    }
}
