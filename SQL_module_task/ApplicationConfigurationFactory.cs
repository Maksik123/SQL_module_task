namespace SQL_module_task
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    public class ApplicationConfigurationFactory : IDesignTimeDbContextFactory<ApplicationConfiguration>
    {
        public ApplicationConfiguration CreateDbContext(string[] args)
        {
            var connectionString = "data source = DESKTOP - 664L1A2; initial catalog = master; trusted_connection = true";
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationConfiguration>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;
            return new ApplicationConfiguration(options);
        }
    }
}
