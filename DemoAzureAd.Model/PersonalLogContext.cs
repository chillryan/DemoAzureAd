using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DemoAzureAd.Model
{
    public class PersonalLogContext : DbContext
    {
        public PersonalLogContext(DbContextOptions<PersonalLogContext> options)
            :base(options)
        {
            var conn = (SqlConnection)Database.GetDbConnection();
        }

        public DbSet<LogEntry> Logs { get; set; }
    }
}