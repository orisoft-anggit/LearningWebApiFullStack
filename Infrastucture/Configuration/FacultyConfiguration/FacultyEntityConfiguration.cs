using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Api.Entities.Faculty;

namespace Web.Api.Infrastucture.Configuration.FacultyConfiguration
{
    public class FacultyEntityConfiguration : IEntityTypeConfiguration<FacultyEntity>
    {
        public void Configure(EntityTypeBuilder<FacultyEntity> builder)
        {
            builder 
                .HasMany(e => e.Lecturers) 
                .WithOne(e => e.Faculty)             
                .HasForeignKey(e => e.facultyId)            
                .OnDelete(DeleteBehavior.NoAction);  

            builder 
                .HasMany(e => e.ProgramStudys)
                .WithOne(e => e.Faculty)
                .HasForeignKey(e => e.facultyId)
                .OnDelete(DeleteBehavior.NoAction); 
            
            builder 
                .HasMany(e => e.Students)
                .WithOne(e => e.Faculty)
                .HasForeignKey(e => e.facultyId)
                .OnDelete(DeleteBehavior.NoAction); 
        }
    }
}