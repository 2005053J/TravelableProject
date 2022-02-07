using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelableProject.Shared.Domain;

namespace TravelableProject.Server.Configurations.Entities
{
    public class DurationSeedConfiguration : IEntityTypeConfiguration<Duration>
    {
        public void Configure(EntityTypeBuilder<Duration> builder)
        {
            builder.HasData(
                new Duration
                {
                    Id = 1,
                    StayTime = "1 Day",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Duration
                {
                    Id = 2,
                    StayTime = "2 Days",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Duration
                {
                    Id = 3,
                    StayTime = "3 Days",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Duration
                {
                    Id = 4,
                    StayTime = "4 Days",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Duration
                {
                    Id = 5,
                    StayTime = "5 Days",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Duration
                {
                    Id = 6,
                    StayTime = "6 Days",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Duration
                {
                    Id = 7,
                    StayTime = "1 Week",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
