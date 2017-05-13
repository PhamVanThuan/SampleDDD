using System;
using System.Data.Entity.Migrations;
using Sample.Entities;

namespace Sample.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SampleDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SampleDbContext context)
        {
            context.Countries.AddOrUpdate(GenerateCountries());
        }

        private Country[] GenerateCountries()
        {
            var countries = new Country[]
            {
                new Country
                {
                    Name = "Vietnam",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    CreatedBy = "",
                    ModifiedBy = ""
                },
                new Country
                {
                    Name = "Korea",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    CreatedBy = "",
                    ModifiedBy = ""
                },
                new Country
                {
                    Name = "China",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    CreatedBy = "",
                    ModifiedBy = ""
                }
        };
            return countries;
        }
    }
}
