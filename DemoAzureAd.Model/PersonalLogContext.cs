using System.Data.SqlClient;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.EntityFrameworkCore;

namespace DemoAzureAd.Model
{
    public class PersonalLogContext : DbContext
    {
        public PersonalLogContext(DbContextOptions<PersonalLogContext> options)
            :base(options)
        {
            var conn = (SqlConnection)Database.GetDbConnection();
            conn.AccessToken = new AzureServiceTokenProvider().GetAccessTokenAsync("https://database.windows.net/").Result;
        }

        public DbSet<LogEntry> LogEntries { get; set; }
    }
}