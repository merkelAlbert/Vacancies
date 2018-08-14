using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace YandexJob.DAL.Models
{
    public class Vacancy
    {
        [Key] public Guid Id { get; set; }
        public string Title { get; set; }
        public string Salary { get; set; }
        public string Company { get; set; }
        public string EmploymentType { get; set; }
        public string Description { get; set; }
    }
}