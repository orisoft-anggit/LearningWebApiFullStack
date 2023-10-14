using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Api.Entities.ProgramStudy;

namespace Web.Api.Infrastucture.Configuration.ProgramStudyConfiguration
{
    public class ProgramStudyEntityConfiguration : IEntityTypeConfiguration<ProgramStudyEntity>
    {
        public void Configure(EntityTypeBuilder<ProgramStudyEntity> builder)
        {
            builder
                .HasMany(e => e.Lecturers)
                .WithOne(e => e.ProgramStudy)
                .HasForeignKey(e => e.studyProgramId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(e => e.Students)
                .WithOne(e => e.ProgramStudy)
                .HasForeignKey(e => e.studyProgramId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}