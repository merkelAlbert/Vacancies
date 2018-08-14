﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp.Dom;
using AngleSharp.Dom.Html;
using Microsoft.AspNetCore.Mvc;
using Vacancies.DAL;
using Vacancies.DAL.Models;
using Vacancies.Services;

namespace Vacancies.Controllers
{
    [Route("[controller]")]
    public class VacanciesController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private readonly ParsingService _parsingService;
        private const string Url = "https://kaluga.hh.ru/catalog/Informacionnye-tehnologii-Internet-Telekom/";

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
        [Route("Update")]
        public async Task<List<Vacancy>> Update()
        {
            List<Vacancy> toDelete = _databaseContext.Vacancies.ToList();
            _databaseContext.RemoveRange(toDelete);
            _databaseContext.SaveChanges();
            
            List<Vacancy> vacancies = await _parsingService.GetVacancies(Url);
            await _databaseContext.Vacancies.AddRangeAsync(vacancies);
            await _databaseContext.SaveChangesAsync();
            return vacancies;
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