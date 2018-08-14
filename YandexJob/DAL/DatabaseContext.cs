using Microsoft.EntityFrameworkCore;
using YandexJob.DAL.Models;

namespace YandexJob.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        
        public DbSet<Vacancy> Vacancies { get; set; }
    }
}