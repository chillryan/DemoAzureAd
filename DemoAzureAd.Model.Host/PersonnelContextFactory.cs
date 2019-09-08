using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DemoAzureAd.Model.Host
{
    public class PersonnelContextFactory : IDesignTimeDbContextFactory<PersonnelContext>
    {
        public PersonnelContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PersonnelContext>();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\msqllocaldb;Initial Catalog=CrewLogs;Trusted_Connection=true;MultipleActiveResultSets=true");

            return new PersonnelContext(optionsBuilder.Options);
        }
    }
}
