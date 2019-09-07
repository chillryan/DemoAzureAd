using Microsoft.EntityFrameworkCore;

namespace DemoAzureAd.Model
{
    public class Personnel : DbContext
    {
        public DbSet<LogEntry> CrewLogs { get; set; }
    }
}