using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Html;
using AngleSharp.Extensions;
using AngleSharp.Network.Default;
using AngleSharp.Parser.Html;
using YandexJob.DAL.Models;

namespace YandexJob.Services
{
    public class ParsingService
    {
        private const string Url = "https://rabota.yandex.ru/search?job_industry=275";

        public async Task<List<Vacancy>> Parse()
        {
            var yandexCookies = new YandexCookies(Url);
            var request = (HttpWebRequest) WebRequest.Create(Url);
            request.CookieContainer = yandexCookies.Cookies;
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:31.0) Gecko/20100101 Firefox/31.0";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            request.Headers.Add(HttpRequestHeader.AcceptLanguage, "en-us,en;q=0.5");
            request.Referer = Url;
            var response = await request.GetResponseAsync();
            var stream = response.GetResponseStream();
            var parser = new HtmlParser();
            var document = await parser.ParseAsync(stream);
            var vacancies = document.QuerySelectorAll("tr.serp-vacancy");

            List<Vacancy> vacanciesList = new List<Vacancy>();
            foreach (var item in vacancies)
            {
                Vacancy vacancy = new Vacancy();
                var title = item.QuerySelector("h3.serp-vacancy__name");
                var company = item.QuerySelector("div.serp-vacancy__company");
                var description = item.QuerySelector("div.serp-vacancy__requirements");
                var employmentType = item.QuerySelector("div.serp-vacancy__schedule");
                var salary = item.QuerySelector("div.serp-vacancy__salary");

                if (title != null)
                {
                    vacancy.Title = title.TextContent;
                }

                if (company != null)
                {
                    vacancy.Company = company.TextContent;
                }

                if (description != null)
                {
                    vacancy.Description = description.TextContent;
                }

                if (employmentType != null)
                {
                    vacancy.EmploymentType = employmentType.TextContent;
                }

                if (salary != null)
                {
                    vacancy.Salary = salary.TextContent;
                }

                vacanciesList.Add(vacancy);
            }

            return vacanciesList;
        }
    }
}