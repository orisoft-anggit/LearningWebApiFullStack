using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Api.Entities.Lecturer;

namespace Web.Api.Infrastucture.Configuration.LecturerConfiguration
{
    public class LecturerEntityConfiguration : IEntityTypeConfiguration<LecturerEntity>
    {
        public void Configure(EntityTypeBuilder<LecturerEntity> builder)
        {
            builder
                .HasMany(e => e.Student)
                .WithOne(e => e.Lecturer)
                .HasForeignKey(e => e.lecturerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}