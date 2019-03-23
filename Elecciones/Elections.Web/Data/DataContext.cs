



namespace Elections.Web.Data
{
    using Elections.Web.Data.Entities;
    using Microsoft.EntityFrameworkCore;

    public class DataContext: DbContext
    {
        public DbSet<Event> Events { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

    }
}
