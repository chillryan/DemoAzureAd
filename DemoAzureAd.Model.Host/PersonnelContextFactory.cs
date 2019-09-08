using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DemoAzureAd.Model.Host
{
    public class PersonnelContextFactory : IDesignTimeDbContextFactory<PersonalLogContext>
    {
        public PersonalLogContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PersonalLogContext>();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\msqllocaldb;Initial Catalog=PersonalLog;Trusted_Connection=true;MultipleActiveResultSets=true");

            return new PersonalLogContext(optionsBuilder.Options);
        }
    }
}
