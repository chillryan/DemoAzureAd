using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DemoAzureAd.Model
{
    public class PersonalLogContext : DbContext
    {
        public PersonalLogContext(DbContextOptions<PersonalLogContext> options)
            :base(options)
        {
            var conn = (SqlConnection)Database.GetDbConnection();
            try
            {
                conn.AccessToken = new AzureServiceTokenProvider().GetAccessTokenAsync("https://database.windows.net/").Result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to retreive token: {ex}");
            }
        }

        public DbSet<LogEntry> LogEntries { get; set; }
    }
}