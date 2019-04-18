

namespace Elections.Web.Data
{    
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;

    public class SeedDB
    {
        private readonly DataContext context;
        private Random random;
        

        public SeedDB(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Events.Any())
            {
                this.AddEvent("First Event");
                this.AddEvent("Second Event");
                this.AddEvent("Third Event");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddEvent(string name)
        {
            this.context.Events.Add(new Event
            {
                Name = name,
                Description = "Insert description",
               IsAvailabe = true,
               StartDate=DateTime.Today,
               EndDate=DateTime.Today,
                Stock = this.random.Next(100)
            });
        }
    }

}
