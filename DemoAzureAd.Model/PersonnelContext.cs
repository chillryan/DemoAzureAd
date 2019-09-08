using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DemoAzureAd.Model
{
    public class PersonnelContext : DbContext
    {
        public PersonnelContext(DbContextOptions<PersonnelContext> options)
            :base(options)
        {
            var conn = (SqlConnection)Database.GetDbConnection();
        }

        public DbSet<LogEntry> CrewLogs { get; set; }
    }
}