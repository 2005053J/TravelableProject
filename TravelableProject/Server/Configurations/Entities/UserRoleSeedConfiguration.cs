using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace TravelableProject.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void
        Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "489e4d75-e0dc-4ac8-ab15-72834102fc89",
                UserId = "18a0ae93-da75-43fd-ba01-7b4f95456194"
            }
            );
        }
    }
}