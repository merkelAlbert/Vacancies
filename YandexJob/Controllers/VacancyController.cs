using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp.Dom;
using AngleSharp.Dom.Html;
using Microsoft.AspNetCore.Mvc;
using YandexJob.DAL;
using YandexJob.DAL.Models;
using YandexJob.Services;

namespace YandexJob.Controllers
{
    [Route("[controller]")]
    public class VacanciesController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private readonly ParsingService _parsingService;


        public VacanciesController(DatabaseContext databaseContext, ParsingService parsingService)
        {
            _databaseContext = databaseContext;
            _parsingService = parsingService;
        }

        [HttpGet]
        public IEnumerable<Vacancy> Get()
        {
            return _databaseContext.Vacancies;
        }

        [HttpGet]
        [Route("Parse")]
        public Task<List<Vacancy>> Parse()
        {
            return _parsingService.Parse();
        }
        /*[HttpGet("{id}")]
        public string Get(G id)
        {
            return "value";
        }*/

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}